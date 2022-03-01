namespace laba2_selector
{
    public partial class selector : Form
    {
        public selector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_money.Text == "" || textBox_users.Text == "" || comboBox_speed.SelectedIndex == -1)
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            int val;
            if (!int.TryParse(textBox_money.Text, out val) || !int.TryParse(textBox_users.Text, out val) || Convert.ToInt32(textBox_users.Text) < 0 || Convert.ToInt32(textBox_money.Text) < 0)
            {
                MessageBox.Show("Поля заполнены неправильно");
                return;
            }

            int speed;
            if (comboBox_speed.Text.Contains("Gb/s"))
            {
                speed = Convert.ToInt32(comboBox_speed.Text.Remove(comboBox_speed.Text.Length - 4))*1000;
            }
            else
            {
                speed = Convert.ToInt32(comboBox_speed.Text.Remove(comboBox_speed.Text.Length - 4));
            }
            try
            {
                results results = new results(Convert.ToInt32(textBox_users.Text), Convert.ToInt32(speed), Convert.ToInt32(textBox_money.Text));

                results.ShowDialog();
                results.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}