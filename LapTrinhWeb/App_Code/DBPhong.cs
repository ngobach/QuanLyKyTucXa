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