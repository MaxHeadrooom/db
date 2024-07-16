using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

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
                            GlobalVariables.sortedRegNumber.Add(reader["reg_number"].ToString());
                            GlobalVariables.sortedDateOfDoc.Add(reader["date_of_doc"].ToString());
                            GlobalVariables.sortedOpisanie.Add(reader["opisanie"].ToString());
                            GlobalVariables.sortedAdresat.Add(reader["adresat"].ToString());
                            GlobalVariables.sortedSkanPdf.Add(reader.IsDBNull(reader.GetOrdinal("skan_pdf")) ? null : (byte[])reader["skan_pdf"]);
                        }
                    }

                    conn.Close();
                }
            }
        }

        public void Size()
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=DB.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string sortSql = "SELECT count(*) from All_Info";
                    cmd.CommandText = sortSql;
                    cmd.Connection = conn;

                    conn.Open();
                    GlobalVariables.size_of_table = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                }
            }
        }

        public void Seek_date()
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=DB.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string sek = GlobalVariables.date_seek_per;
                    string finder = "SELECT * FROM All_Info WHERE date_of_doc = @sek";
                    cmd.CommandText = finder;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@sek", sek);

                    conn.Open();

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable resultTable = new DataTable();
                        adapter.Fill(resultTable);
                        GlobalVariables.temp_db = resultTable;
                    }
                    
                    conn.Close();
                }
            }
        }

        public void Seek_reg()
        {
            // Проверяем, что у нас есть предыдущая версия temp_db
            if (GlobalVariables.temp_db == null || GlobalVariables.temp_db.Rows.Count == 0)
            {
                MessageBox.Show("Нет предыдущих данных для выполнения запроса.");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection("data source=DB.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    // Используем регистрационный номер из предыдущей версии temp_db
                    string sek = GlobalVariables.temp_db.Rows[0]["reg_number"].ToString();
                    string finder = "SELECT * FROM All_Info WHERE reg_number = @sek";
                    cmd.CommandText = finder;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@sek", sek);

                    conn.Open();

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable resultTable = new DataTable();
                        adapter.Fill(resultTable);

                        GlobalVariables.temp_db = resultTable;

                    }

                    conn.Close();
                }
            }
        }


        public void Seek_adr()
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=DB.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string sek = GlobalVariables.adr_seek_per;
                    string finder = "SELECT * FROM All_Info WHERE adresat = @sek";
                    cmd.CommandText = finder;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@sek", sek);

                    conn.Open();

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable resultTable = new DataTable();
                        adapter.Fill(resultTable);
                        GlobalVariables.temp_db = resultTable;
                    }

                    conn.Close();
                }
            }
        }
    }
}
