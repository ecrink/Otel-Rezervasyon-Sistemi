using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon2.DAL
{
    internal class dbbaglanti
    {
        public MySqlConnection bagla()
        {
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330020; Uid=25_132330020; Pwd=!nif.ogr20KA");
                baglanti.Open();
                return baglanti;
            }
        }
    }
}
