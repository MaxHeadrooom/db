using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_frame
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void when_start()
        {
            DBHelper dBHelper = new DBHelper();
            dBHelper.SortAndPrint();
            dBHelper.Size();

            for (int i = 0; i < GlobalVariables.size_of_table; i++)
            {
                outputTextBox.AppendText($"Reg Number: {GlobalVariables.sortedRegNumber[i]}, Date: {GlobalVariables.sortedDateOfDoc[i]}, Opisanie: {GlobalVariables.sortedOpisanie[i]}, Adresat: {GlobalVariables.sortedAdresat[i]}\r\n");
            }
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        bool fl_reg_box = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!fl_reg_box)
            {
                Reg_box.Clear();
                fl_reg_box = true;
            }
        }

        bool fl_date_box = false;
        private void date_box_TextChanged(object sender, EventArgs e)
        {
            if (!fl_date_box)
            {
                date_box.Clear();
                fl_date_box = true;
            }
        }

        bool fl_adr_box = false;
        private void adr_box_TextChanged(object sender, EventArgs e)
        {
            if (!fl_adr_box)
            {
                adr_box.Clear();
                fl_adr_box = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            if (Reg_box.Text == "")
            {
                Reg_box.Text = "Регистрационный номер";
                when_start();
            }
            else
            {
                GlobalVariables.reg_seek_per = Reg_box.Text;

                DBHelper dBHelper = new DBHelper();
                dBHelper.Seek_reg();

                int size_temp_db = GlobalVariables.temp_db.Rows.Count;

                for (int i = 0; i < size_temp_db; i++)
                {
                    DataRow row = GlobalVariables.temp_db.Rows[i];
                    outputTextBox.AppendText($"Reg Number: {row["reg_number"]}, Date: {row["date_of_doc"]}, Opisanie: {row["opisanie"]}, Adresat: {row["adresat"]}\r\n");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            if (date_box.Text == "")
            {
                date_box.Text = "Дата документа";
                when_start();
            }
            else
            {
                GlobalVariables.date_seek_per = date_box.Text;

                DBHelper dBHelper = new DBHelper();
                dBHelper.Seek_date();

                int size_temp_db = GlobalVariables.temp_db.Rows.Count;

                for (int i = 0; i < size_temp_db; i++)
                {
                    DataRow row = GlobalVariables.temp_db.Rows[i];
                    outputTextBox.AppendText($"Reg Number: {row["reg_number"]}, Date: {row["date_of_doc"]}, Opisanie: {row["opisanie"]}, Adresat: {row["adresat"]}\r\n");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            if (adr_box.Text == "")
            {
                adr_box.Text = "Адресат";
                when_start();
            }
            else
            {
                GlobalVariables.adr_seek_per = adr_box.Text;

                DBHelper dBHelper = new DBHelper();
                dBHelper.Seek_adr();

                int size_temp_db = GlobalVariables.temp_db.Rows.Count;

                for (int i = 0; i < size_temp_db; i++)
                {
                    DataRow row = GlobalVariables.temp_db.Rows[i];
                    outputTextBox.AppendText($"Reg Number: {row["reg_number"]}, Date: {row["date_of_doc"]}, Opisanie: {row["opisanie"]}, Adresat: {row["adresat"]}\r\n");
                }
            }
        }
    }
}


