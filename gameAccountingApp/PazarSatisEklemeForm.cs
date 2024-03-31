using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameAccountingApp
{
    public partial class PazarSatisEklemeForm : Form
    {
        int? id=null;
        public PazarSatisEklemeForm(int? Id=null)
        {
            InitializeComponent();
            if (Id != null )
            {
                this.id = Id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id == null) 
            {
                double fiyat1 = double.Parse(PazarFiyatitextBox.Text) * 98 / 100;
                double fiyat2 = double.Parse(MiktartextBox.Text);
                double fiyat3 = fiyat2 * fiyat1;
                Console.WriteLine(fiyat3);
                Baglan.Connection.Open();
                string nick = SaticicomboBox.Text;
                string query = "Select id FROM KullaniciAdi WHERE Nick = @Nick";//DİKKAT nick
                SQLiteCommand command = new SQLiteCommand(query,Baglan.Connection);
                command.Parameters.Add(new SQLiteParameter("@Nick",nick));
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

                DateTime dateTime = DateTime.Now;
                string sql = "Insert into pazarSatis(NickId,Date,UrunId,Adet,PazarFiyati,NetFiyat) Values('"+ KullaniciId + "','"+dateTime.ToShortDateString()+"','"+ UrunId + "','"+MiktartextBox.Text+"','"+PazarFiyatitextBox.Text+"','"+ fiyat3 + "')";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Ekleme İşlemi Başarılı!");
                    this.Close();
                }
            }
            else
            {
                double fiyat1 = double.Parse(PazarFiyatitextBox.Text) * 98 / 100;
                double fiyat2 = double.Parse(MiktartextBox.Text);
                double fiyat3 = fiyat2 * fiyat1;

                Baglan.Connection.Open();
                string nick = SaticicomboBox.Text;
                string query = "Select id FROM KullaniciAdi WHERE Nick = @Nick";//DİKKAT nick
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

                DateTime dateTime = DateTime.Now;
                string sql = "Update pazarSatis set NickId='" + KullaniciId + "',UrunId='" + UrunId + "',Adet='" + MiktartextBox.Text + "',PazarFiyati='" + PazarFiyatitextBox.Text + "',NetFiyat='" + fiyat3 + "'Where id='"+id+"'";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı!");
                    this.Close();
                }
            }
        }

        private void PazarSatisEklemeForm_Load(object sender, EventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM KullaniciAdi", Baglan.Connection);
            SQLiteCommand command2 = new SQLiteCommand("SELECT * FROM SatilacakUrunler", Baglan.Connection);
            SQLiteDataReader dr,dr2;
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
