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
    public partial class SatilacakEsyaEkleForm : Form
    {
        public SatilacakEsyaEkleForm()
        {
            InitializeComponent();
        }

        private void ItemKaydetBtn_Click(object sender, EventArgs e)
        {
            string sql = "Insert into SatilacakUrunler(UrunAdi) Values('" + ItemAditextBox.Text + "')";
            if (CRUD.ESG(sql))
            {
                MessageBox.Show("Ekleme İşlemi Başarılı!");
                this.Close();
            }
        }
    }
}
