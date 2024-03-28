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
                string sql = "Insert into EldenSatis(NickId,Date,UrunId,Adet,NetFiyat) Values('" + SaticicomboBox.Text + "','" + dateTime.ToShortDateString() + "','" + UruncomboBox.Text + "','" + MiktartextBox.Text + "','" + PazarFiyatitextBox.Text + "')";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Ekleme İşlemi Başarılı!");
                    this.Close();
                }
            }
            else
            {
                DateTime dateTime = DateTime.Now;
                string sql = "Update EldenSatis set NickId='" + SaticicomboBox.Text + "',UrunId='" + UruncomboBox.Text + "',Adet='" + MiktartextBox.Text + "',NetFiyat='" + PazarFiyatitextBox.Text + "'Where id='" + id + "'";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı!");
                    this.Close();
                }
            }
        }
    }
}
