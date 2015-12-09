using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using LapTrinhWeb.Models;


namespace LapTrinhWeb.App_Code
{
    public class DBPhong : DB
    {
        public static DataTable SelectAll()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Phong", GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        public static DataTable SelectEmpty(int except = 0)
        {
            DataTable table = new DataTable();
            SqlCommand cmd;
            if (except==0)
                cmd = new SqlCommand("SELECT * FROM Phong WHERE (SELECT COUNT(*) FROM HopDong WHERE HopDong.Phong = Phong.ID AND HopDong.DaKetThuc = 0)=0", GetConnection());
            else { 
                cmd = new SqlCommand("SELECT * FROM Phong WHERE (SELECT COUNT(*) FROM HopDong WHERE HopDong.Phong = Phong.ID AND HopDong.DaKetThuc = 0)=0 OR ID=@except", GetConnection());
                cmd.Parameters.AddWithValue("@except", except);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public static void Insert(String tenphong)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Phong (TenPhong) VALUES (@tenphong)",GetConnection());
            cmd.Parameters.AddWithValue("@tenphong", tenphong);
            cmd.ExecuteNonQuery();
        }
        public static void Update(int id, String tenphong)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Phong SET TenPhong=@tenphong WHERE ID=@id", GetConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tenphong", tenphong);
            cmd.ExecuteNonQuery();
        }
        public static void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Phong WHERE ID=@id", GetConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}