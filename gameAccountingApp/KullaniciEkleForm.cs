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
    public partial class KullaniciEkleForm : Form
    {
        int? id = null;
        public KullaniciEkleForm(int? Id = null)
        {
            InitializeComponent();
            if (Id != null)
            {
                this.id = Id;
            }
        }

        private void NickKaydetBtn_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                string sql = "Insert into KullaniciAdi(Nick,Email) Values('" + NicktextBox.Text + "','" + EMailtextBox.Text + "')";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Ekleme İşlemi Başarılı!");
                    this.Close();
                }
            }
            else
            {
                string sql = "Update KullaniciAdi set Nick='" + NicktextBox.Text + "',Email='" + EMailtextBox.Text + "'Where id='" + id + "'";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı!");
                    this.Close();
                }
            }
        }
    }
}
