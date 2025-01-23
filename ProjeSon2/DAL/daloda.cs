using MySql.Data.MySqlClient;
using ProjeSon2;
using ProjeSon2.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjeSon2.DAL.daloda;

namespace ProjeSon2.DAL
{
    internal class daloda
    {
        public class OdaVeriErisim
        {
            public DataTable OdalariGetir()
            {
                DataTable odaTablosu = new DataTable();
                string sorgu = "SELECT * FROM tbl_oda";
                using (MySqlCommand komut = new MySqlCommand(sorgu, new dbbaglanti().bagla()))
                {
                    MySqlDataAdapter adaptor = new MySqlDataAdapter(komut);
                    adaptor.Fill(odaTablosu);
                }
                return odaTablosu;
            }
        }

        public void OdaEkle(string Oturu, int Ofiyat, string Odurum)
        {
            string kaydet = "INSERT INTO tbl_oda (oda_turu,oda_fiyatı,oda_durum) VALUES (@oda_turu,@oda_fiyatı, @oda_durum)";
            using (MySqlCommand komut = new MySqlCommand(kaydet, new dbbaglanti().bagla()))
            {
                komut.Parameters.AddWithValue("@oda_turu", Oturu);
                komut.Parameters.AddWithValue("@oda_fiyat", Ofiyat);
                komut.Parameters.AddWithValue("@oda_durum", Odurum);
                komut.ExecuteNonQuery();
            }
        }
        public void OdaGuncelle(int oNo, string Oturu, int Ofiyat, string Odurum)
        {
            string guncelle = "UPDATE tbl_oda SET oda_turu = @Oda_turu, Oda_fiyatı = @Oda_fiyatı, Oda_Durumu = @Oda_Durumu WHERE Oda_Id = @Oda_Id";
            using (MySqlCommand komut = new MySqlCommand(guncelle, new dbbaglanti().bagla()))
            {
                komut.Parameters.AddWithValue("@Oda_Id", oNo);
                komut.Parameters.AddWithValue("@Oda_turu", Oturu);
                komut.Parameters.AddWithValue("@Oda_fiyatı", Ofiyat);
                komut.Parameters.AddWithValue("@Oda_Durumu", Odurum);
                komut.ExecuteNonQuery();
            }
        }
        public void OdaSil(int id)
        {
            string sorgu = "DELETE FROM tbl_oda WHERE Oda_Id = @oda_Id";

            using (MySqlCommand komut = new MySqlCommand(sorgu, new dbbaglanti().bagla()))
            {
                komut.Parameters.AddWithValue("@Oda_Id", id);
                komut.ExecuteNonQuery();
            }
        }
    }
}

