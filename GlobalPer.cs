using System;
using System.Collections.Generic;
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
    }
}
