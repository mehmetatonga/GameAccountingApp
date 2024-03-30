using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameAccountingApp
{
    public partial class EldenSatisEklemeForm : Form
    {
        int? id = null;
        public EldenSatisEklemeForm(int? Id = null)
        {
            InitializeComponent();
            if (Id != null)
            {
                this.id = Id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                DateTime dateTime = DateTime.Now;

                Baglan.Connection.Open();
                string nick = SaticicomboBox.Text;
                string query = "Select id FROM KullaniciAdi WHERE Nick = @Nick";
                SQLiteCommand command = new SQLiteCommand(query, Baglan.Connection);
                command.Parameters.Add(new SQLiteParameter("@Nick", nick));
                object result = command.ExecuteScalar();
                int KullaniciId = Convert.ToInt32(result);
                Baglan.Connection.Close();

                Baglan.Connection.Open();
                string urunAdi = UruncomboBox.Text;
                string query2 = "Select id FROM SatilacakUrunler WHERE UrunAdi = @UrunAdi";
                SQLiteCommand command2 = new SQLiteCommand(query2, Baglan.Connection);
                command2.Parameters.Add(new SQLiteParameter("@UrunAdi", urunAdi));
                object result2 = command2.ExecuteScalar();
                int UrunId = Convert.ToInt32(result2);
                Baglan.Connection.Close();

                float ToplamMiktar = float.Parse(MiktartextBox.Text)* float.Parse(PazarFiyatitextBox.Text);
                string sql = "Insert into EldenSatis(NickId,Date,UrunId,Adet,NetFiyat,ToplamFiyat) Values('" + KullaniciId + "','" + dateTime.ToShortDateString() + "','" + UrunId + "','" + MiktartextBox.Text + "','" + PazarFiyatitextBox.Text + "','"+ ToplamMiktar + "')";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Ekleme İşlemi Başarılı!");
                    this.Close();
                }
            }
            else
            {
                DateTime dateTime = DateTime.Now;

                Baglan.Connection.Open();
                string nick = SaticicomboBox.Text;
                string query = "Select id FROM KullaniciAdi WHERE Nick = @Nick";
                SQLiteCommand command = new SQLiteCommand(query, Baglan.Connection);
                command.Parameters.Add(new SQLiteParameter("@Nick", nick));
                object result = command.ExecuteScalar();
                int KullaniciId = Convert.ToInt32(result);
                Baglan.Connection.Close();

                Baglan.Connection.Open();
                string urunAdi = UruncomboBox.Text;
                string query2 = "Select id FROM SatilacakUrunler WHERE UrunAdi = @UrunAdi";
                SQLiteCommand command2 = new SQLiteCommand(query2, Baglan.Connection);
                command2.Parameters.Add(new SQLiteParameter("@UrunAdi", urunAdi));
                object result2 = command2.ExecuteScalar();
                int UrunId = Convert.ToInt32(result2);
                Baglan.Connection.Close();

                float ToplamMiktar = float.Parse(MiktartextBox.Text) * float.Parse(PazarFiyatitextBox.Text);
                string sql = "Update EldenSatis set NickId='" + KullaniciId + "',UrunId='" + UrunId + "',Adet='" + MiktartextBox.Text + "',NetFiyat='" + PazarFiyatitextBox.Text + "',ToplamFiyat='"+ ToplamMiktar + "'Where id='" + id + "'";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı!");
                    this.Close();
                }
            }
        }

        private void EldenSatisEklemeForm_Load(object sender, EventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM KullaniciAdi", Baglan.Connection);
            SQLiteCommand command2 = new SQLiteCommand("SELECT * FROM SatilacakUrunler", Baglan.Connection);
            SQLiteDataReader dr, dr2;
            Baglan.Connection.Open();
            dr = command.ExecuteReader();
            dr2 = command2.ExecuteReader();
            while (dr.Read())
            {
                SaticicomboBox.Items.Add(dr["Nick"]);
            }
            while (dr2.Read())
            {
                UruncomboBox.Items.Add(dr2["UrunAdi"]);
            }
            Baglan.Connection.Close();
        }
    }
}
