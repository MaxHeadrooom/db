using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_frame
{
    public static class GlobalVariables
    {
        public static string RegNumber { get; set; }
        public static string Day { get; set; }
        public static string Month { get; set; }
        public static string Year { get; set; }

        public static string GetDate()
        {
            return $"{Year}-{Month}-{Day}";
        }

        public static string Opisanie {  get; set; }

        public static List<string> Glob_Adresat {  get; set; }

        public static byte[] skan {  get; set; }

        public static List<string> sortedRegNumber { get; set; } = new List<string>();  
        public static List<string> sortedDateOfDoc { get; set; } = new List<string>();
        public static List<string> sortedOpisanie { get; set; } = new List<string>();  
        public static List<string> sortedAdresat { get; set; } = new List<string>();
        public static List<byte[]> sortedSkanPdf { get; set; }= new List<byte[]>();

        public static int size_of_table { get; set; }

        public static string reg_seek_per {  get; set; }
        public static string date_seek_per { get; set; }
        public static string adr_seek_per { get; set; }

        public static DataTable temp_db { get; set; }

    }
}
