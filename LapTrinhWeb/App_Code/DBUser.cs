using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using LapTrinhWeb.Models;

namespace LapTrinhWeb.Models
{
    public class User
    {
        public String UID;
        public String FullName;
        public String DOB;
        public String Addr;
    }
}

namespace LapTrinhWeb.App_Code
{
    public class DBUser : DB
    {

        public static DataTable SelectAll()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("User_DanhSach", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public static User GetUser(String uid)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE [Username]=@uid",GetConnection());
            cmd.Parameters.AddWithValue("@uid", uid);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                reader.Close();
                return null;
            }
            User user = new User();
            user.UID = uid;
            user.FullName = (String)reader["HoTen"];
            user.DOB = ((DateTime)reader["NgaySinh"]).ToString("yyyy-MM-dd");
            user.Addr = (String)reader["QueQuan"];
            reader.Close();
            return user;
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