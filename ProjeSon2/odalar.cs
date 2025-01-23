using ProjeSon2.ENTİTYLAYER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjeSon2.DAL.daloda;
using static ProjeSon2.ENTİTYLAYER.eloda;

namespace ProjeSon2
{
    public partial class odalar : Form
    {
        public odalar()
        {
            InitializeComponent();
        }
        private OdaIslemleri odaIslemleri = new OdaIslemleri();
        private void OdaBilgileriniYukle()
        {
         
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //int OdaId = int.Parse(txtodaNo.Text);
                int fiyat = int.Parse(txtOdaFiyat.Text);
                string tür = cmcboxOdatur.Text;
                string durum = cbdoluluk.Text;

                (new eloda()).OdaEkle(fiyat, tür, durum);
                MessageBox.Show("Yeni oda başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void odalar_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
