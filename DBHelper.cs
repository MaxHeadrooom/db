using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

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

        public void Save()
        {
            string reg_number = GlobalVariables.RegNumber;
            string date_of_doc = GlobalVariables.GetDate();
            string opisanie = GlobalVariables.Opisanie;
            byte[] skan_pdf = GlobalVariables.skan;

            string adress = string.Join("$", GlobalVariables.Glob_Adresat);

            All_Info single = new All_Info(reg_number, date_of_doc, adress, opisanie, skan_pdf);

            using (SQLiteConnection conn = new SQLiteConnection("data source=DB.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string insertSql = "INSERT INTO [All_Info] ([reg_number], [date_of_doc], [opisanie], [skan_pdf], [adresat]) " +
                                       "VALUES (@reg_number, @date_of_doc, @opisanie, @skan_pdf, @adresat)";
                    cmd.CommandText = insertSql;
                    cmd.Connection = conn;

                    // Добавляем параметры к команде
                    cmd.Parameters.AddWithValue("@reg_number", reg_number);
                    cmd.Parameters.AddWithValue("@date_of_doc", date_of_doc);
                    cmd.Parameters.AddWithValue("@opisanie", opisanie);
                    cmd.Parameters.AddWithValue("@skan_pdf", skan_pdf);
                    cmd.Parameters.AddWithValue("@adresat", adress);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Сортируем данные после добавления
                    string sortSql = "SELECT * FROM All_Info ORDER BY date_of_doc DESC";
                    cmd.CommandText = sortSql;

                    
                    conn.Close();
                }
            }
        }
        public void SortAndPrint()
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=DB.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string sortSql = "SELECT * FROM All_Info ORDER BY date_of_doc DESC";
                    cmd.CommandText = sortSql;
                    cmd.Connection = conn;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Обработка данных
                            string sortedRegNumber = reader["reg_number"].ToString();
                            string sortedDateOfDoc = reader["date_of_doc"].ToString();
                            string sortedOpisanie = reader["opisanie"].ToString();
                            string sortedAdresat = reader["adresat"].ToString();
                            byte[] sortedSkanPdf = reader.IsDBNull(reader.GetOrdinal("skan_pdf")) ? null : (byte[])reader["skan_pdf"];

                            Console.WriteLine($"Reg Number: {sortedRegNumber}, Date: {sortedDateOfDoc}, Opisanie: {sortedOpisanie}, Adresat: {sortedAdresat}");
                        }
                    }
                }
            }
        }
    }
}
