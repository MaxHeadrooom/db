namespace main_frame
{
    partial class menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.Reg_box = new System.Windows.Forms.TextBox();
            this.date_box = new System.Windows.Forms.TextBox();
            this.adr_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextBox.Location = new System.Drawing.Point(70, 60);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(1137, 600);
            this.outputTextBox.TabIndex = 4;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // Reg_box
            // 
            this.Reg_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reg_box.Location = new System.Drawing.Point(70, 696);
            this.Reg_box.Multiline = true;
            this.Reg_box.Name = "Reg_box";
            this.Reg_box.Size = new System.Drawing.Size(517, 60);
            this.Reg_box.TabIndex = 5;
            this.Reg_box.Text = "Регистрационный номер";
            this.Reg_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // date_box
            // 
            this.date_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_box.Location = new System.Drawing.Point(70, 787);
            this.date_box.Multiline = true;
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(517, 60);
            this.date_box.TabIndex = 6;
            this.date_box.Text = "Дата документа";
            this.date_box.TextChanged += new System.EventHandler(this.date_box_TextChanged);
            // 
            // adr_box
            // 
            this.adr_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adr_box.Location = new System.Drawing.Point(70, 879);
            this.adr_box.Multiline = true;
            this.adr_box.Name = "adr_box";
            this.adr_box.Size = new System.Drawing.Size(517, 60);
            this.adr_box.TabIndex = 7;
            this.adr_box.Text = "Адресат";
            this.adr_box.TextChanged += new System.EventHandler(this.adr_box_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(624, 696);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(624, 787);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 59);
            this.button2.TabIndex = 9;
            this.button2.Text = "Применить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(624, 880);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 59);
            this.button3.TabIndex = 10;
            this.button3.Text = "Применить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1267, 995);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adr_box);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.Reg_box);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox Reg_box;
        private System.Windows.Forms.TextBox date_box;
        private System.Windows.Forms.TextBox adr_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}