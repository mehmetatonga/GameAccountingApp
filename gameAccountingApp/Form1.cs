using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameAccountingApp
{
    public partial class EldenSatisLbl : Form
    {
        public EldenSatisLbl()
        {
            InitializeComponent();
            PazarSatisListele();
            EldenSatisListele();
            GbSatisListele();
            PazarciListele();
        }
        public void PazarSatisListele()
        {
            //string sql = "Select * from pazarSatis";
            string sql = "Select pazarSatis.id,pazarSatis.Date,KullaniciAdi.Nick,SatilacakUrunler.UrunAdi,pazarSatis.Adet,pazarSatis.PazarFiyati,Cast(NetFiyat as varchar) as NetFiyat from pazarSatis INNER JOIN KullaniciAdi on pazarSatis.NickId=KullaniciAdi.id INNER JOIN SatilacakUrunler on pazarSatis.UrunId=SatilacakUrunler.id";
            PazarSatisGridWiew.DataSource = CRUD.Listele(sql);
        }
        public void EldenSatisListele()
        {
            //string sql = "Select * from EldenSatis";
            string sql = "Select EldenSatis.id,EldenSatis.Date,KullaniciAdi.Nick,SatilacakUrunler.UrunAdi,EldenSatis.Adet,EldenSatis.NetFiyat from EldenSatis INNER JOIN KullaniciAdi on EldenSatis.NickId=KullaniciAdi.id INNER JOIN SatilacakUrunler on EldenSatis.UrunId=SatilacakUrunler.id";
            EldenSatisGridWiew.DataSource = CRUD.Listele(sql);
        }
        public void GbSatisListele()
        {
            //string sql = "Select * from GbSatis";
            string sql = "Select id,Date,Miktar,Cast(MFiyati as varchar) as MFiyati,Cast(ToplamTutar as varchar) as ToplamTutar from GbSatis";
            GbSatisGridWiew.DataSource = CRUD.Listele(sql);
        }
        public void PazarciListele()
        {
            string sql = "Select * from KullaniciAdi";
            //string sql = "Select id,Date,Miktar,Cast(MFiyati as varchar) as MFiyati,Cast(ToplamTutar as varchar) as ToplamTutar from GbSatis";
            PazarcıDataGridView1.DataSource = CRUD.Listele(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili kayıt silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int seciliId = Convert.ToInt32(EldenSatisGridWiew.CurrentRow.Cells["id"].Value.ToString());
                string sql = "Delete from EldenSatis Where id='" + seciliId + "'";
                if (CRUD.ESG(sql))
                {
                    EldenSatisListele();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(PazarSatisGridWiew.CurrentRow.Cells["id"].Value.ToString());
            PazarSatisEklemeForm frm = new PazarSatisEklemeForm(seciliId);
            frm.SaticicomboBox.Text = PazarSatisGridWiew.CurrentRow.Cells["Nick"].Value.ToString();
            frm.UruncomboBox.Text = PazarSatisGridWiew.CurrentRow.Cells["UrunAdi"].Value.ToString();
            frm.MiktartextBox.Text = PazarSatisGridWiew.CurrentRow.Cells["Adet"].Value.ToString();
            frm.PazarFiyatitextBox.Text = PazarSatisGridWiew.CurrentRow.Cells["PazarFiyati"].Value.ToString();
            frm.ShowDialog();
            PazarSatisListele();
        }

        private void PazarSatisiEkleBtn_Click(object sender, EventArgs e)
        {
            PazarSatisEklemeForm frm = new PazarSatisEklemeForm();
            frm.ShowDialog();
            PazarSatisListele();
        }

        private void PazarSatisiSilBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili kayıt silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int seciliId = Convert.ToInt32(PazarSatisGridWiew.CurrentRow.Cells["id"].Value.ToString());
                string sql = "Delete from pazarSatis Where id='" + seciliId + "'";
                if (CRUD.ESG(sql))
                {
                    PazarSatisListele();
                } 
            }
        }

        private void EldenSatisEkleBtn_Click(object sender, EventArgs e)
        {
            EldenSatisEklemeForm frm = new EldenSatisEklemeForm();
            frm.ShowDialog();
            EldenSatisListele();
        }

        private void EldenSatisGuncelleBtn_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(EldenSatisGridWiew.CurrentRow.Cells["id"].Value.ToString());
            EldenSatisEklemeForm frm = new EldenSatisEklemeForm(seciliId);
            frm.SaticicomboBox.Text = EldenSatisGridWiew.CurrentRow.Cells["Nick"].Value.ToString();
            frm.UruncomboBox.Text = EldenSatisGridWiew.CurrentRow.Cells["UrunAdi"].Value.ToString();
            frm.MiktartextBox.Text = EldenSatisGridWiew.CurrentRow.Cells["Adet"].Value.ToString();
            frm.PazarFiyatitextBox.Text = EldenSatisGridWiew.CurrentRow.Cells["NetFiyat"].Value.ToString();
            frm.ShowDialog();
            EldenSatisListele();
        }

        private void GBSatisiEkleBtn_Click(object sender, EventArgs e)
        {
            GBSatisEkleForm frm = new GBSatisEkleForm();
            frm.ShowDialog();
            GbSatisListele();
        }

        private void GBSatisiGuncelleBtn_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(GbSatisGridWiew.CurrentRow.Cells["id"].Value.ToString());
            GBSatisEkleForm frm = new GBSatisEkleForm(seciliId);
            frm.MiktarTxt.Text = GbSatisGridWiew.CurrentRow.Cells["Miktar"].Value.ToString();
            frm.MFiyatitextBox.Text = GbSatisGridWiew.CurrentRow.Cells["MFiyati"].Value.ToString();
            frm.ShowDialog();
            GbSatisListele();
        }

        private void GBSatisiSilBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili kayıt silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int seciliId = Convert.ToInt32(GbSatisGridWiew.CurrentRow.Cells["id"].Value.ToString());
                string sql = "Delete from GbSatis Where id='" + seciliId + "'";
                if (CRUD.ESG(sql))
                {
                    GbSatisListele();
                }
            }
        }

        private void UrunEkleBtn_Click(object sender, EventArgs e)
        {
            SatilacakEsyaEkleForm frm = new SatilacakEsyaEkleForm();
            frm.ShowDialog();
        }

        private void KullaniciEkleBtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm frm = new KullaniciEkleForm();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm frm = new KullaniciEkleForm();
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(PazarcıDataGridView1.CurrentRow.Cells["id"].Value.ToString());
            KullaniciEkleForm frm = new KullaniciEkleForm(seciliId);
            frm.NicktextBox.Text = PazarcıDataGridView1.CurrentRow.Cells["Nick"].Value.ToString();
            frm.EMailtextBox.Text = PazarcıDataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            frm.ShowDialog();
            PazarciListele();
        }

        private void PazarciSilBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili kayıt silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int seciliId = Convert.ToInt32(PazarcıDataGridView1.CurrentRow.Cells["id"].Value.ToString());
                string sql = "Delete from KullaniciAdi Where id='" + seciliId + "'";
                if (CRUD.ESG(sql))
                {
                    PazarciListele();
                }
            }
        }

        private void GameAccountingAppForm_Load(object sender, EventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM KullaniciAdi", Baglan.Connection);
            SQLiteCommand command2 = new SQLiteCommand("SELECT DISTINCT Date FROM (SELECT Date FROM PazarSatis UNION SELECT Date FROM EldenSatis) AS CombinedDates", Baglan.Connection);
            SQLiteDataReader dr,dr2;
            Baglan.Connection.Open();
            dr = command.ExecuteReader();
            dr2 = command2.ExecuteReader();
            while (dr.Read())
            {
                PazarCharcomboBox1.Items.Add(dr["Nick"]);
            }
            while (dr2.Read())
            {
                DatecomboBox1.Items.Add(dr2["Date"]);
            }
            Baglan.Connection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Baglan.Connection.Open();
            string nick = PazarCharcomboBox1.Text;
            string query = "Select id FROM KullaniciAdi WHERE Nick = @Nick";//DİKKAT nick
            SQLiteCommand command = new SQLiteCommand(query, Baglan.Connection);
            command.Parameters.Add(new SQLiteParameter("@Nick", nick));
            object result = command.ExecuteScalar();
            int KullaniciId = Convert.ToInt32(result);

            //string query2 = "SELECT  NetFiyat FROM pazarSatis Where NickId=@nickId AND Date=@date";
            //SQLiteCommand command2 = new SQLiteCommand(query2, Baglan.Connection);
            //command2.Parameters.AddWithValue("@nickId", KullaniciId);
            //command2.Parameters.AddWithValue("@date", DatecomboBox1.Text);
            //SQLiteDataReader reader = command2.ExecuteReader();
            //if (reader.Read())
            //{
            //    double netFiyat = reader.GetDouble(0);
            //    PazarSatisLbl.Text = "Pazar Satış: "+netFiyat.ToString();
            //}
            //else
            //{
            //    PazarSatisLbl.Text = "Pazar Satış: 0";
            //}
            
            string query2 = "SELECT  NetFiyat FROM pazarSatis Where NickId=@nickId AND Date=@date";
            SQLiteCommand command2 = new SQLiteCommand(query2, Baglan.Connection);
            command2.Parameters.AddWithValue("@nickId", KullaniciId);
            command2.Parameters.AddWithValue("@date", DatecomboBox1.Text);
            SQLiteDataReader reader = command2.ExecuteReader();
            float toplamNetFiyat = 0;

            while (reader.Read())
            {
                float NetFiyat = Convert.ToSingle(reader["NetFiyat"]);
                toplamNetFiyat += NetFiyat;
            }
            PazarSatisLbl.Text = "Pazar Satış: " + toplamNetFiyat.ToString("0,##", new CultureInfo("tr-TR")); //GPT ABİYE SOR

            Baglan.Connection.Close();
            
        }

        private void KarHesaplabutton1_Click(object sender, EventArgs e)
        {
            float altToplam = float.Parse(PazardanGelenParatextBox3.Text) + float.Parse(GbSatistextBox4.Text);
            float ustToplam = float.Parse(RPRtextBox1.Text) + float.Parse(RocotextBox2.Text);
            float karToplam = altToplam - ustToplam;
            KarLabel.Text = "KAR: "+ karToplam.ToString();
        }
    }
}
