using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LapTrinhCSharp
{
    public class DB
    {
        public const int ERR_CONFLICK = 2627;       // Lỗi trùng khóa chính hoặc khóa unique
        public const int ERR_FK_REFERENCE = 547;    // Lỗi trùng khóa chính hoặc khóa unique
        public const string CONNECTION_STRING = "Server=.;Uid=sa;Pwd=123456;Database=QLKTX";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            conn.Open();
            return conn;
        }
    }
}
