using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_frame
{
    public class All_Info
    {
        public int id { get; set; }

        public byte[] skan_pdf { get; set; }

        public string reg_number, date_of_doc, adresat, opisanie;

        public string Reg_number
        {
            get { return reg_number; }
            set { reg_number = value; }
        }

        public string Date_of_doc
        {
            get { return date_of_doc; }
            set { date_of_doc = value; }
        }
        public string Adresat
        {
            get { return adresat; }
            set { adresat = value; }
        }
        public string Opisanie
        {
            get { return opisanie; }
            set { opisanie = value; }
        }

        public All_Info() { }

        public All_Info(string date_of_doc, string reg_number, string adresat, string opisanie, byte[] skan_pdf)
        {
            this.date_of_doc = date_of_doc;
            this.reg_number = reg_number;
            this.adresat = adresat;
            this.opisanie = opisanie;
            this.skan_pdf = skan_pdf;
        }   
    }
}
