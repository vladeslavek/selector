using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2_selector
{
    public partial class results : Form
    {
        public results(int users, int speed, int money)
        {
            InitializeComponent();
            Database.Init();
            List<Item> routers = new List<Item>(); //все роутеры (макс скорость)
            List<Commutator> comms = new List<Commutator>(); //все коммутаторы (макс пользователей)
            List<Item> cables = new List<Item>(); //все кабели (мин цена)

            foreach (var got in Database.Get())
            {
                if (got.Type == "router" && got.Speed >= speed)
                {
                    routers.Add(got);
                }
                if (got.Type == "commutator" && got.Speed >= speed)
                {
                    Commutator commutator = (Commutator)got;
                    if (commutator.Users >= users)
                    {
                        comms.Add((Commutator)got);
                    }
                }
                if (got.Type == "cable" && got.Speed >= speed)
                {
                    cables.Add(got);
                }
            }

            if (routers.Count == 0 || comms.Count == 0 || cables.Count == 0)
            {
                throw new Exception("Подходящих комбинаций не было найдено");
            }
            richTextBox_combos.Text = "";
            foreach (var got in routers)
            {
                foreach (var foo in comms)
                {
                    foreach(var bar in cables)
                    {
                        int cost = got.Price + foo.Price + bar.Price * users;
                        if (cost < money)
                            richTextBox_combos.Text += $"Маршрутизатор - '{got.Name}', коммутатор - '{foo.Name}', кабель - {bar.Name} {users}м, итого {cost}р.\n";
                    }
                }
            }
            if (richTextBox_combos.Text == "")
            {
                throw new Exception("Подходящих комбинаций не было найдено");
            }
            label_got.Text = "Подобрано комбинаций: " + (richTextBox_combos.Text.Split("\n").Length-1);
        }

        class Item
        {
            public string Name { get; protected set; } //роутер-234
            public string Type { get; protected set; } //маршрутизатор
            public int Speed { get; protected set; } //10Mb/s
            public int Price { get; protected set; } //1000р

            public Item(string data)
            {
                string[] str = data.Split(' ');
                Name = str[0].Replace('_', ' ');
                Type = str[1];
                int speed = Convert.ToInt32(str[2].Remove(str[2].Length - 4));
                if (str[2].Contains("Gb/s"))
                {
                    Speed = speed * 1000;
                }
                else
                    Speed = speed;
                Price = Convert.ToInt32(str[3]);
            }
        }
        
        class Commutator : Item
        {
            public int Users { get; private set; }

            public Commutator(string data) : base(data)
            {
                string[] str = data.Split(' ');
                Name = str[0].Replace('_', ' ');
                Type = str[1];
                int speed = Convert.ToInt32(str[2].Remove(str[2].Length - 4));
                if (str[2].Contains("Gb/s"))
                {
                    Speed = speed * 1000;
                }
                else
                    Speed = speed;
                Price = Convert.ToInt32(str[3]);
                Users = Convert.ToInt32(str[4]);
            }
        }

        static class Database
        {
            static List<Item> allItems = new List<Item>();

            public static void Refresh()
            {
                allItems.Clear();
            }

            public static void Init()
            {
                var thisAssembly = Assembly.GetExecutingAssembly();
                //string[] str = thisAssembly.GetManifestResourceNames();
                using (var stream = thisAssembly.GetManifestResourceStream("laba2_selector.resources.database.txt"))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        string[] read = reader.ReadToEnd().Replace("\r\n", "\n").Split("\n");
                        foreach (var got in read)
                        {
                            if (got.Split(' ').Length == 5)
                            {
                                allItems.Add(new Commutator(got));
                            }
                            else
                            {
                                allItems.Add(new Item(got));
                            }
                        }
                    }
                }
            }

            public static List<Item> Get()
            {
                return allItems;
            }
        }

        private void results_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.Refresh();
        }
    }
}
