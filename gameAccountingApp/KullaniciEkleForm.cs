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
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }

        private void NickKaydetBtn_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KullaniciAdi(Nick) Values('" + NicktextBox.Text + "')";
            if (CRUD.ESG(sql))
            {
                MessageBox.Show("Ekleme İşlemi Başarılı!");
                this.Close();
            }
        }
    }
}
