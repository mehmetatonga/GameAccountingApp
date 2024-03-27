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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PazarSatisListele();
            EldenSatisListele();
            GbSatisListele();
        }
        void PazarSatisListele()
        {
            string sql = "Select * from pazarSatis";
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
    }
}
