using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_frame
{
    public class DBHelper
    {
        private readonly ApplicationContext db;

        public DBHelper()
        {
            // Создание DbContextOptions
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlite("Data Source=DefaultConnection.db");

            // Передача DbContextOptions в конструктор ApplicationContext
            db = new ApplicationContext(optionsBuilder.Options);
        }

        public void Connect()
        {
            string reg_number = GlobalVariables.RegNumber;
            string date_of_doc = GlobalVariables.GetDate();
            string opisanie = GlobalVariables.Opisanie;
            byte[] skan_pdf = GlobalVariables.skan;

            string adress = "";

            foreach (string temp in GlobalVariables.Glob_Adresat)
            {
                adress = adress + temp + "$";
            }

            All_Info single = new All_Info(reg_number, date_of_doc, adress, opisanie, skan_pdf);
            db.All_Info.Add(single);
            db.SaveChanges();
        }
    }
}
