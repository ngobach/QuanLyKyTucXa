using System;
using System.Data;
using System.Data.SqlClient;

namespace LapTrinhCSharp.Models
{
    class User
    {
        public string Username { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }

        public static bool Check(string uid, string pwd,out string fullname)
        {
            bool f = false;
            fullname = "";
            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE Username=@uid AND MatKhau=@pwd",con);
                cmd.Parameters.AddWithValue("@uid", uid);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (f = reader.Read())
                    {
                        fullname = reader["HoTen"].ToString();
                    }
                }
            }
            return f;
        }

        public static DataTable All()
        {
            DataTable table = new DataTable();
            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [User]", con);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)){
                    adapter.Fill(table);
                }
            }
            return table;
        }

        public void Create()
        {
            using (SqlConnection con = DB.GetConnection())
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [User] VALUES (@uid,@pwd,@name,@dob,@addr)",con))
            {
                cmd.Parameters.AddWithValue("@uid", Username);
                cmd.Parameters.AddWithValue("@pwd", MatKhau);
                cmd.Parameters.AddWithValue("@name", HoTen);
                cmd.Parameters.AddWithValue("@dob", NgaySinh);
                cmd.Parameters.AddWithValue("@addr", QueQuan);
                cmd.ExecuteNonQuery();
            }
        }
        public void Update(String oldID)
        {
            if (MatKhau != String.Empty)
                using (SqlConnection con = DB.GetConnection())
                using (SqlCommand cmd = new SqlCommand("UPDATE [User] SET Username=@uid,MatKhau=@pwd,HoTen=@name,NgaySinh=@dob,QueQuan=@addr WHERE Username=@oldid", con))
                {
                    cmd.Parameters.AddWithValue("@uid", Username);
                    cmd.Parameters.AddWithValue("@pwd", MatKhau);
                    cmd.Parameters.AddWithValue("@name", HoTen);
                    cmd.Parameters.AddWithValue("@dob", NgaySinh);
                    cmd.Parameters.AddWithValue("@addr", QueQuan);
                    cmd.Parameters.AddWithValue("@oldid", oldID);
                    cmd.ExecuteNonQuery();
                }
            else
                using (SqlConnection con = DB.GetConnection())
                using (SqlCommand cmd = new SqlCommand("UPDATE [User] SET Username=@uid,HoTen=@name,NgaySinh=@dob,QueQuan=@addr WHERE Username=@oldid", con))
                {
                    cmd.Parameters.AddWithValue("@uid", Username);
                    cmd.Parameters.AddWithValue("@name", HoTen);
                    cmd.Parameters.AddWithValue("@dob", NgaySinh);
                    cmd.Parameters.AddWithValue("@addr", QueQuan);
                    cmd.Parameters.AddWithValue("@oldid", oldID);
                    cmd.ExecuteNonQuery();
                }

        }
        public void Delete()
        {
            using (SqlConnection con = DB.GetConnection())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM [User] WHERE Username=@uid", con))
            {
                cmd.Parameters.AddWithValue("@uid", Username);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
