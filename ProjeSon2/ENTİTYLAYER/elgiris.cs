using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon2.ENTİTYLAYER
{
    internal class elgiris
    {
        private string girisKullanici;
        private string girisSifre;

        public string GİRİSKULLANİCİ { get { return girisKullanici; } set { girisKullanici = value; } }
        public string GİRİSSİFRE { get { return girisSifre; } set { girisSifre = value; } }
        public elgiris(string muterigirisKullanici, string musterigirisSifre)
        {
            this.girisKullanici = girisKullanici;
            this.girisSifre = girisSifre;
        }
        public override string ToString()
        {
            return this.girisKullanici + "-" + this.girisSifre;
        }
    }
}
