using ProjeSon2.DAL;
using ProjeSon2.ENTİTYLAYER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Datatypes.Scalar.Types;

namespace ProjeSon2.BL
{
    internal class blrezervasyon
    {
        internal void rezervasyonkaydet(string musteriId,string musteriad, string musterisoyad, string odaNo, string odaTipi, string girisTarihi, string cikisTarihi)
        {
            (new dalrezervasyon()).rezkaydet(new elrezervasyon(musteriId,musteriad, musterisoyad, odaNo, odaTipi, girisTarihi, cikisTarihi));
        }

        public DataTable dataverial()
        {
            dalrezervasyon data1 = new dalrezervasyon();
            return data1.ver();
        }
        internal void rezsil(string a)
        {
            (new dalrezervasyon()).rezsil(a);
        }
        
        private dalrezervasyon dalrez = new dalrezervasyon ();
        public bool rezguncelle(string musteriId, string musteriad, string musterisoyad, string odaNo, string odaTipi, string girisTarihi, string cikisTarihi)
        {
            return dalrez.rezervasyonguncelle(musteriId, musteriad, musterisoyad, odaNo, odaTipi, girisTarihi, cikisTarihi);
        }
    }

}

