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
        void PazarSatisListele()
        {
            //string sql = "Select * from pazarSatis";
            string sql = "Select Date,NickId,UrunId,Adet,PazarFiyati,NetFiyat from pazarSatis";
            PazarSatisGridWiew.DataSource = CRUD.Listele(sql);
        }
        void EldenSatisListele()
        {
            string sql = "Select * from EldenSatis";
            EldenSatisGridWiew.DataSource = CRUD.Listele(sql);
        }
        void GbSatisListele()
        {
            string sql = "Select * from GbSatis";
            GbSatisGridWiew.DataSource = CRUD.Listele(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
