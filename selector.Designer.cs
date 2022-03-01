namespace laba2_selector
{
    partial class selector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label_users = new System.Windows.Forms.Label();
            this.textBox_users = new System.Windows.Forms.TextBox();
            this.label_speed = new System.Windows.Forms.Label();
            this.comboBox_speed = new System.Windows.Forms.ComboBox();
            this.label_money = new System.Windows.Forms.Label();
            this.textBox_money = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(531, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Подобрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_users
            // 
            this.label_users.AutoSize = true;
            this.label_users.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_users.Location = new System.Drawing.Point(342, 56);
            this.label_users.Name = "label_users";
            this.label_users.Size = new System.Drawing.Size(367, 27);
            this.label_users.TabIndex = 1;
            this.label_users.Text = "Введите кол-во пользователей: ";
            // 
            // textBox_users
            // 
            this.textBox_users.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_users.Location = new System.Drawing.Point(748, 53);
            this.textBox_users.MaxLength = 3;
            this.textBox_users.Name = "textBox_users";
            this.textBox_users.Size = new System.Drawing.Size(121, 30);
            this.textBox_users.TabIndex = 2;
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_speed.Location = new System.Drawing.Point(342, 201);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(402, 27);
            this.label_speed.TabIndex = 3;
            this.label_speed.Text = "Введите пропускную способность: ";
            // 
            // comboBox_speed
            // 
            this.comboBox_speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_speed.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_speed.FormattingEnabled = true;
            this.comboBox_speed.Items.AddRange(new object[] {
            "10 Mb/s",
            "100 Mb/s",
            "1 Gb/s",
            "10 Gb/s"});
            this.comboBox_speed.Location = new System.Drawing.Point(748, 201);
            this.comboBox_speed.Name = "comboBox_speed";
            this.comboBox_speed.Size = new System.Drawing.Size(121, 31);
            this.comboBox_speed.TabIndex = 4;
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_money.Location = new System.Drawing.Point(342, 365);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(408, 27);
            this.label_money.TabIndex = 5;
            this.label_money.Text = "Введите выделенные средства (₽): ";
            // 
            // textBox_money
            // 
            this.textBox_money.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_money.Location = new System.Drawing.Point(748, 362);
            this.textBox_money.MaxLength = 6;
            this.textBox_money.Name = "textBox_money";
            this.textBox_money.Size = new System.Drawing.Size(121, 30);
            this.textBox_money.TabIndex = 6;
            // 
            // selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.textBox_money);
            this.Controls.Add(this.label_money);
            this.Controls.Add(this.comboBox_speed);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.textBox_users);
            this.Controls.Add(this.label_users);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "selector";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label_users;
        private TextBox textBox_users;
        private Label label_speed;
        private ComboBox comboBox_speed;
        private Label label_money;
        private TextBox textBox_money;
    }
}