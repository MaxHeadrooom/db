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
    public partial class Reg : Form
    {
        string reg_number = "";

        string day = "", month = "", year = "";

        public Reg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void reg_num_TextChanged(object sender, EventArgs e)
        {
            GlobalVariables.RegNumber = reg_num.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.RegNumber != "" && GlobalVariables.Day != "" && GlobalVariables.Month != "" && GlobalVariables.Year != "" && GlobalVariables.Year != "-1" && GlobalVariables.Month != "-1" && GlobalVariables.Day != "-1")
            {
                this.Hide();
                adrskan adrskan = new adrskan();
                adrskan.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Day_int(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Запрет ввода символа
            }
        }

        private void Day_TextChanged(object sender, EventArgs e)
        {
            // Проверяем длину текста
            if (Day.Text.Length > 2)
            {
                Day.Text = Day.Text.Substring(0, 2); // Ограничиваем длину текста двумя символами
            }
            else
            {
                switch (Day.Text.Length)
                {
                    case 1:
                    {
                            GlobalVariables.Day = '0' + Day.Text;
                        break;
                    }
                    case 2:
                        {
                            GlobalVariables.Day = Day.Text;
                            break;
                        }
                    default:
                        {
                            GlobalVariables.Day = "-1";
                            break;
                        }
                }

            }
        }

        private void Month_int(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Запрет ввода символа
            }
        }

        private void Month_TextChanged(object sender, EventArgs e)
        {
            // Проверяем длину текста
            if (Month.Text.Length > 2)
            {
                Month.Text = Month.Text.Substring(0, 2); // Ограничиваем длину текста двумя символами
            }
            else
            {
                switch (Month.Text.Length)
                {
                    case 1:
                        {
                            GlobalVariables.Month = '0' + Month.Text;
                            break;
                        }
                    case 2:
                        {
                            GlobalVariables.Month = Month.Text;
                            break;
                        }
                    default:
                        {
                            GlobalVariables.Month = "-1";
                            break;
                        }
                }

            }
        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void Year_int(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Запрет ввода символа
            }
        }

        private void Year_TextChanged(object sender, EventArgs e)
        {
            // Проверяем длину текста
            if (Year.Text.Length > 4)
            {
                Year.Text = Year.Text.Substring(0, 4); // Ограничиваем длину текста двумя символами
            }
            else
            {
                switch (Year.Text.Length)
                {
                    case 4:
                        {
                            GlobalVariables.Year = Year.Text;
                            break;
                        }
                    default:
                        {
                            GlobalVariables.Year = "-1";
                            break;
                        }
                }

            }
        }
    }
}
