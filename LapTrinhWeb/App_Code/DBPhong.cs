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
            if (except == 0)
            {
                cmd = new SqlCommand("WEB_Phong_SelectEmpty", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd = new SqlCommand("WEB_Phong_SelectEmptyID", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@except", except);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public static void Insert(String tenphong)
        {
            SqlCommand cmd = new SqlCommand("WEB_Phong_Insert", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenphong", tenphong);
            cmd.ExecuteNonQuery();
        }
        public static void Update(int id, String tenphong)
        {
            SqlCommand cmd = new SqlCommand("WEB_Phong_Update", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tenphong", tenphong);
            cmd.ExecuteNonQuery();
        }
        public static void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("WEB_Phong_Delete", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}