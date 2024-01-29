using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazLab1_1
{
    public class KriterListeleme
    {
        public KriterListeleme(string ogrenciNo, string ogrenciAdi, double kriterOrt)
        {
            this.ogrenciNo = ogrenciNo;
            this.ogrenciAdi = ogrenciAdi;
            this.kriterOrt = kriterOrt;
        }

        public string ogrenciNo { get; set; }

        public string ogrenciAdi { get; set; }

        public double kriterOrt { get; set; }


    }
}
