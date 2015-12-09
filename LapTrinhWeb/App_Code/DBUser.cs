using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace LapTrinhWeb.App_Code
{
    public class DBUser : LapTrinhWeb.App_Code.DB
    {

        public class SinhVien
        {
            public String masv, hoten, gioitinh, quequan, makhoa, malop;
        }

        public static DataTable SelectAll()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("User_DanhSach", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        

        public static void Insert(String username, String password,String hoten,DateTime ngaysinh, String quequan)
        {
            SqlCommand cmd = new SqlCommand("User_Them", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@quequan", quequan);
            cmd.ExecuteNonQuery();
        }

        public static void Update(String username, String password, String hoten, DateTime ngaysinh, String quequan)
        {
            SqlCommand cmd = new SqlCommand("User_CapNhat", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@quequan", quequan);
            cmd.ExecuteNonQuery();
        }

        public static void Delete(String username)
        {
            SqlCommand cmd = new SqlCommand("User_Xoa", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.ExecuteNonQuery();
        }
        public static bool IsValid(String username, String password)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Username=@username AND MatKhau=@password", GetConnection());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            int result = (int)cmd.ExecuteScalar();
            return result > 0;
        }
    }
}