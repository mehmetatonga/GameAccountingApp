using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameAccountingApp
{
    public partial class GameAccountingAppForm : Form
    {
        public GameAccountingAppForm()
        {
            InitializeComponent();
            PazarSatisListele();
            EldenSatisListele();
            GbSatisListele();
        }
        public void PazarSatisListele()
        {
            //string sql = "Select * from pazarSatis";
            string sql = "Select pazarSatis.id,pazarSatis.Date,KullaniciAdi.Nick,pazarSatis.UrunId,pazarSatis.Adet,pazarSatis.PazarFiyati,pazarSatis.NetFiyat from pazarSatis INNER JOIN KullaniciAdi on pazarSatis.NickId=KullaniciAdi.id"; //İki inner join birden yazmak lazım onun çözümünü bul.
            PazarSatisGridWiew.DataSource = CRUD.Listele(sql);
        }
        public void EldenSatisListele()
        {
            //string sql = "Select * from EldenSatis";
            string sql = "Select id,Date,NickId,UrunId,Adet,NetFiyat from EldenSatis";
            EldenSatisGridWiew.DataSource = CRUD.Listele(sql);
        }
        public void GbSatisListele()
        {
            //string sql = "Select * from GbSatis";
            string sql = "Select id,Date,Miktar,Cast(MFiyati as varchar) as MFiyati,Cast(ToplamTutar as varchar) as ToplamTutar from GbSatis";
            GbSatisGridWiew.DataSource = CRUD.Listele(sql);
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
            frm.UruncomboBox.Text = PazarSatisGridWiew.CurrentRow.Cells["UrunId"].Value.ToString();
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
            frm.SaticicomboBox.Text = EldenSatisGridWiew.CurrentRow.Cells["NickId"].Value.ToString();
            frm.UruncomboBox.Text = EldenSatisGridWiew.CurrentRow.Cells["UrunId"].Value.ToString();
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
    }
}
