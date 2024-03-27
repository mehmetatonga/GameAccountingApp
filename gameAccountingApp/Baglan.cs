using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameAccountingApp
{
    public class Baglan
    {
        public static SQLiteConnection Connection = new SQLiteConnection("Data source=.\\GameAccApp.db;Versiyon=3");
    }
}
