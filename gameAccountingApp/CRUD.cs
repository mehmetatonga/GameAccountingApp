using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameAccountingApp
{
    public class CRUD
    {
        static DataTable dt;
        public static DataTable Listele(string sql) 
        { 
            dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql,Baglan.Connection);
            adtr.Fill(dt);
            return dt;
        }

    }
}
