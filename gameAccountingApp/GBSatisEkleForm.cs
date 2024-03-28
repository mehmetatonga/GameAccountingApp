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
    public partial class GBSatisEkleForm : Form
    {
        int? id = null;
        public GBSatisEkleForm(int? Id = null)
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
                int fiyat1 = Int32.Parse(MiktarTxt.Text);
                float fiyat2 = float.Parse(MFiyatitextBox.Text);
                float fiyat3 = fiyat1 * fiyat2;
                DateTime dateTime = DateTime.Now;
                string sql = "Insert into GbSatis(Date,Miktar,MFiyati,ToplamTutar) Values('" + dateTime.ToShortDateString() + "','" + MiktarTxt.Text + "','" + MFiyatitextBox.Text + "','"+fiyat3+"')";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Ekleme İşlemi Başarılı!");
                    this.Close();
                }
            }
            else
            {
                int fiyat1 = Int32.Parse(MiktarTxt.Text);
                float fiyat2 = float.Parse(MFiyatitextBox.Text);
                float fiyat3 = fiyat1 * fiyat2;
                DateTime dateTime = DateTime.Now;
                string sql = "Update GbSatis set Miktar='" + MiktarTxt.Text + "', MFiyati='" + MFiyatitextBox.Text + "',ToplamTutar='" + fiyat3 + "'Where id='" + id + "'";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı!");
                    this.Close();
                }
            }
        }
    }
}
