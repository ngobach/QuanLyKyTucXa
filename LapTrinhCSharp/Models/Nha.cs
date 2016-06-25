using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhCSharp.Models
{
    class Nha
    {
        public static DataTable All()
        {
            var table = new DataTable();
            using (var con = DB.GetConnection())
            using (var adapter = new SqlDataAdapter("SELECT * FROM Nha", con))
            {
                adapter.Fill(table);
            }
            return table;
        }
    }
}
