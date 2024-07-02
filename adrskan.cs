using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_frame
{
    public partial class adrskan : Form
    {
        public adrskan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Reg reg = new Reg();
            reg.Show();
        }

        private void vibor_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                byte[] fileBytes = File.ReadAllBytes(filePath);

                GlobalVariables.skan = fileBytes;
            }
        }

        List<string> adres = new List<string>();
        string s = "", all_s = "";

        private void adresat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
                all_s = all_s + e.KeyChar;
            else
            {
                if (all_s.Length > 0) 
                    all_s = all_s.Substring(0, all_s.Length - 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            adresat.Text = all_s;
        }

        string opisa = "";

        private void opisanie_TextChanged(object sender, EventArgs e)
        {
            opisa = opisanie.Text;
            GlobalVariables.Opisanie = opisa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = adresat.Text;
            s1 += '\r';
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == '\r')
                {
                    adres.Add(s);
                }
                else
                {
                    if (s1[i] == ',')
                    {
                        adres.Add(s);
                        s = "";
                    }
                    else
                    {
                        if (s1[i] != ' ')
                            s += s1[i];
                    }
                }
            }
            GlobalVariables.Glob_Adresat = adres;

            DBHelper dbHelper = new DBHelper();

            dbHelper.Connect();

            this.Hide();
            Form1 form1 = new Form1(); 
            form1.Show();
        }

    }
}
