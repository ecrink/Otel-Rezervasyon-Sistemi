using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon2.ENTİTYLAYER
{
    internal class elrezervasyon
    {
      
        private string musteriAd;
        private string musteriSoyad;
        private string odaNo;
        private string girisTarihi;
        private string cikisTarihi;
        private string odaTipi;
        private string musteriId;




        public string MUSTERİAD { get { return musteriAd; } set { musteriAd = value; } }
        public string MUSTERİSOYAD { get { return musteriSoyad; } set { musteriSoyad = value; } }
        public string ODANO { get { return odaNo; } set { odaNo = value; } }
        public string ODATİPİ { get { return odaTipi; } set { odaTipi = value; } }
        public string MUSTERİID { get { return musteriId; } set { musteriId = value; } }    
        public string GIRISTARIHI { get { return girisTarihi  ; } set { girisTarihi = value; } }
        public string CIKISTARIHI { get { return cikisTarihi; } set { cikisTarihi = value; } }


        public elrezervasyon(string musteriId,string musteriad, string musterisoyad,  string odaNo, string odaTipi, string girisTarihi, string cikisTarihi)
        {

            this.musteriAd = musteriad;
            this.musteriId = musteriId;
            this.musteriSoyad = musterisoyad;
            this.odaNo = odaNo;
            this.odaTipi = odaTipi;
            this.girisTarihi = girisTarihi;
            this.cikisTarihi = cikisTarihi;


        }

       

        public override string ToString()
        {
            return this.musteriAd + "-" + this.musteriSoyad + "-"  + "-" + this.odaTipi + this.odaNo + this.musteriId + "-" + this.girisTarihi + "-" + this.cikisTarihi;
        }
public class Oda
        {
            public Oda(int oNo, string Oturu, int Ofiyat, string Odurum)
            {
                this.oId = oNo;
                this.OdaFiyat = Ofiyat;
                this.OdaTuru = Oturu;
                this.OdaDurum = Odurum;
            }
            public Oda(string Oturu, int Ofiyat, string Odurum)
            {

                this.OdaTuru = Oturu;
                this.OdaFiyat = Ofiyat;
                this.OdaDurum = Odurum;
            }

            int odaId;
            public int oId
            {
                get { return odaId; }
                set { odaId = value; }
            }

            string odaTuru;
            public string OdaTuru
            {
                get { return odaTuru; }
                set { odaTuru = value; }
            }
            int odaFiyat;
            public int OdaFiyat
            {
                get { return odaFiyat; }
                set { odaFiyat = value; }
            }
            string odaDurum;
            public string OdaDurum
            {
                get { return odaDurum; }
                set { odaDurum = value; }
            }
            public override string ToString()
            {
                return this.oId + " <-> " + this.OdaTuru + " <-> " + this.OdaFiyat + " <-> " + this.OdaDurum;
            }
        }
    }
}

