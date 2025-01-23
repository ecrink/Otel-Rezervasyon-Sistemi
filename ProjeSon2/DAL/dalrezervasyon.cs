using MySql.Data.MySqlClient;
using ProjeSon2.BL;
using ProjeSon2.DAL;
using ProjeSon2.ENTİTYLAYER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon2.DAL
{
    internal class dalrezervasyon
    {
        public void rezkaydet(elrezervasyon a)
        {
            MySqlDataReader mySqlDataReader = new MySqlCommand("insert into musteri (musteri_ad,musteri_soyad, musteri_id,oda_no,oda_tipi,giris_tarihi,cikis_tarihi) values ('" + a.MUSTERİAD + "','" + a.MUSTERİSOYAD + "','" + a.ODATİPİ + "','" + "','" + a.ODANO + "','" + a.GIRISTARIHI + "','" + a.CIKISTARIHI + "')", (new dbbaglanti()).bagla()).ExecuteReader();

        }
        public DataTable ver()
        {
            using (MySqlConnection ecr = new MySqlConnection("Server=172.21.54.253; Database=25_132330020; Uid=25_132330020; Pwd=!nif.ogr20KA"))
            {
                using (MySqlCommand kmd = new MySqlCommand("select musteri_ad,musteri_soyad,musteri_id,oda_no,oda_tipi,giris_tarihi,cikis_tarihi from musteri", ecr))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(kmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public void rezsil(string a)
        {
            new MySqlCommand("delete from musteri where musteri_id=" + a, (new dbbaglanti()).bagla()).ExecuteReader();
        }
        private string connectionstring = "Server=172.21.54.253; Database=25_132330020; Uid=25_132330020; Pwd=!nif.ogr20KA";

        public bool rezervasyonguncelle(string musteriId, string musteriad, string musterisoyad, string odaNo, string odaTipi, string girisTarihi, string cikisTarihi)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                string query = "update musteri set musteri_ad=@p1,musteri_soyad=@p2,musteri_id=@p3,oda_no=@p4,giris_tarihi=@p5,cikis_tarihi=@p6 where musteri_id=@p3";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@p3", musteriId);
                cmd.Parameters.AddWithValue("@p1", musteriad);
                cmd.Parameters.AddWithValue("@p2", musterisoyad);
                cmd.Parameters.AddWithValue("@p4", odaNo);
                cmd.Parameters.AddWithValue("@p5", girisTarihi);
                cmd.Parameters.AddWithValue("@p6", cikisTarihi);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
} 


   
    
