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
                int netFiyat = Int32.Parse(PazarFiyatitextBox.Text)*98/100;
                DateTime dateTime = DateTime.Now;
                string sql = "Insert into pazarSatis(NickId,Date,UrunId,Adet,PazarFiyati,NetFiyat) Values('"+SaticicomboBox.Text+"','"+dateTime.ToShortDateString()+"','"+UruncomboBox.Text+"','"+MiktartextBox.Text+"','"+PazarFiyatitextBox.Text+"','"+ netFiyat + "')";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Ekleme İşlemi Başarılı!");
                    this.Close();
                }
            }
            else
            {
                int netFiyat = Int32.Parse(PazarFiyatitextBox.Text) * 98 / 100;
                DateTime dateTime = DateTime.Now;
                string sql = "Update pazarSatis set NickId='" + SaticicomboBox.Text + "',UrunId='" + UruncomboBox.Text + "',Adet='" + MiktartextBox.Text + "',PazarFiyati='" + PazarFiyatitextBox.Text + "',NetFiyat='" + netFiyat + "'Where id='"+id+"'";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı!");
                    this.Close();
                }
            }
        }
    }
}
