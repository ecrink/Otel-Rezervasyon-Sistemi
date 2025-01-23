using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon2.BL
{
    internal class bloda
    {
      
            public bloda(int oNo, string Oturu, int Ofiyat, string Odurum)
            {
                this.oId = oNo;
                this.OdaFiyat = Ofiyat;
                this.OdaTuru = Oturu;
                this.OdaDurum = Odurum;
            }
            public bloda(string Oturu, int Ofiyat, string Odurum)
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

