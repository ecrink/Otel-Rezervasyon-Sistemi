using ProjeSon2.BL;
using ProjeSon2.DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeSon2
{
    
    public partial class anasayfa : Form
    {
        private blrezervasyon blrezerr = new blrezervasyon();
        public anasayfa()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            (new blrezervasyon()).rezervasyonkaydet(anasayfaidTxt.Text,anasayfaadTxt.Text, anasayfasoyadTxt.Text, odanoCmbbx.Text, odatipiCmbbx.Text,dateTimePicker1.Text, dateTimePicker2.Text);
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            blrezervasyon ble = new blrezervasyon();
            DataTable dt = ble.dataverial();
            dataGridView1.DataSource = dt;

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                anasayfaadTxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                anasayfasoyadTxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                anasayfaidTxt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                dateTimePicker2.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                odatipiCmbbx.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                odanoCmbbx.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            }
        }
     
      

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            string musteriId =anasayfaidTxt.Text;
            string musteriad = anasayfaadTxt.Text;
            string musterisoyad = anasayfasoyadTxt.Text;
            string odaNo = odanoCmbbx.Text;
            string odaTipi = odatipiCmbbx.Text;
            string giris = dateTimePicker1.Text;
            string cikis = dateTimePicker2.Text;

            bool isUpdated =blrezerr.rezguncelle(musteriId, musteriad,musterisoyad,odaNo,odaTipi,giris,cikis);

        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            (new dalrezervasyon()).rezsil(anasayfaidTxt.Text);
        }

        private void odalarbtn_Click(object sender, EventArgs e)
        {
            (new odalar()).Show();
        }
    }
}
