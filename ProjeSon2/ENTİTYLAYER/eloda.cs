using ProjeSon2.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjeSon2.DAL.daloda;

namespace ProjeSon2.ENTİTYLAYER
{
    public class eloda
    {
            public class OdaIslemleri
            {
                private OdaVeriErisim veriErisim = new OdaVeriErisim();

                public DataTable oda()
                {
                    return veriErisim.OdalariGetir();
                }
            }
            internal void OdaEkle(int Ofiyat, string Oturu, string Odurum)
            {
                (new daloda()).OdaEkle(Oturu, Ofiyat, Odurum);
            }

           

            internal void OdaGuncelle(int oNo, string Oturu, int Ofiyat, string Odurum)
            {
                new daloda().OdaGuncelle(oNo, Oturu, Ofiyat, Odurum);
            }
            public void OdaSil(int id)
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Geçerli bir ID girin.");
                }

                new daloda().OdaSil(id);
            }
        }
    

}

