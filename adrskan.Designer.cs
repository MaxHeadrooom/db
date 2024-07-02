namespace main_frame
{
    partial class adrskan
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
            this.components = new System.ComponentModel.Container();
            this.adresat = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opisanie = new System.Windows.Forms.TextBox();
            this.opis = new System.Windows.Forms.Label();
            this.fail = new System.Windows.Forms.Label();
            this.vibor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adresat
            // 
            this.adresat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adresat.Location = new System.Drawing.Point(113, 99);
            this.adresat.Multiline = true;
            this.adresat.Name = "adresat";
            this.adresat.Size = new System.Drawing.Size(975, 61);
            this.adresat.TabIndex = 0;
            this.adresat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.adresat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adresat_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // adr
            // 
            this.adr.AutoSize = true;
            this.adr.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adr.Location = new System.Drawing.Point(499, 30);
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(181, 48);
            this.adr.TabIndex = 2;
            this.adr.Text = "Адресат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // opisanie
            // 
            this.opisanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opisanie.Location = new System.Drawing.Point(113, 273);
            this.opisanie.Multiline = true;
            this.opisanie.Name = "opisanie";
            this.opisanie.Size = new System.Drawing.Size(975, 244);
            this.opisanie.TabIndex = 5;
            this.opisanie.TextChanged += new System.EventHandler(this.opisanie_TextChanged);
            // 
            // opis
            // 
            this.opis.AutoSize = true;
            this.opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opis.Location = new System.Drawing.Point(403, 187);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(373, 48);
            this.opis.TabIndex = 6;
            this.opis.Text = "Краткое описание";
            // 
            // fail
            // 
            this.fail.AutoSize = true;
            this.fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fail.Location = new System.Drawing.Point(463, 537);
            this.fail.Name = "fail";
            this.fail.Size = new System.Drawing.Size(287, 48);
            this.fail.TabIndex = 7;
            this.fail.Text = "Выбор файла";
            // 
            // vibor
            // 
            this.vibor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vibor.Location = new System.Drawing.Point(438, 630);
            this.vibor.Name = "vibor";
            this.vibor.Size = new System.Drawing.Size(329, 51);
            this.vibor.TabIndex = 8;
            this.vibor.Text = "Выбрать файл";
            this.vibor.UseVisualStyleBackColor = true;
            this.vibor.Click += new System.EventHandler(this.vibor_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(46, 630);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 75);
            this.button2.TabIndex = 9;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(930, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 75);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить в БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adrskan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vibor);
            this.Controls.Add(this.fail);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.opisanie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adr);
            this.Controls.Add(this.adresat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adrskan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adrskan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adresat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label adr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox opisanie;
        private System.Windows.Forms.Label opis;
        private System.Windows.Forms.Label fail;
        private System.Windows.Forms.Button vibor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}