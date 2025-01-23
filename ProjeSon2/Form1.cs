using MySql.Data.MySqlClient;
using ProjeSon2.BL;
using ProjeSon2.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dbbaglanti snf = new dbbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            (new blgiris()).girisbilgi(txtkullanıcıad.Text, txtsifre.Text);
            MySqlCommand komut = new MySqlCommand("select * from yonetici where yonetici_ad =@e1 and yonetici_sifre=@e2", snf.bagla());
            komut.Parameters.AddWithValue("@e1", txtkullanıcıad.Text);
            komut.Parameters.AddWithValue("@e2", txtsifre.Text);
            MySqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                anasayfa fr = new anasayfa();
                fr.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Giriş Bilgileriniz Hatalıdır");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

