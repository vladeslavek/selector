namespace laba2_selector
{
    partial class results
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_got = new System.Windows.Forms.Label();
            this.richTextBox_combos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label_got
            // 
            this.label_got.AutoSize = true;
            this.label_got.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_got.Location = new System.Drawing.Point(460, 9);
            this.label_got.Name = "label_got";
            this.label_got.Size = new System.Drawing.Size(306, 27);
            this.label_got.TabIndex = 2;
            this.label_got.Text = "Подобранные комбинации";
            // 
            // richTextBox_combos
            // 
            this.richTextBox_combos.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_combos.Location = new System.Drawing.Point(12, 57);
            this.richTextBox_combos.Name = "richTextBox_combos";
            this.richTextBox_combos.Size = new System.Drawing.Size(1240, 578);
            this.richTextBox_combos.TabIndex = 3;
            this.richTextBox_combos.Text = "";
            // 
            // results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.richTextBox_combos);
            this.Controls.Add(this.label_got);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "results";
            this.ShowIcon = false;
            this.Text = "Results";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.results_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_got;
        private RichTextBox richTextBox_combos;
    }
}