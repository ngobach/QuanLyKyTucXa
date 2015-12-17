using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace LapTrinhCSharp
{
    public class Phong
    {
        public int ID;
        public string TenPhong;

        public static DataTable All()
        {
            DataTable table = new DataTable();
            using (SqlConnection con = DB.GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Phong", con))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(table);
            }
            return table;
        }
        public void Create()
        {
            using (SqlConnection con = DB.GetConnection())
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Phong (TenPhong) VALUES (@ten)",con))
            {
                cmd.Parameters.AddWithValue("@ten", TenPhong);
                cmd.ExecuteNonQuery();
            }
        }
        public void Update()
        {
            using (SqlConnection con = DB.GetConnection())
            using (SqlCommand cmd = new SqlCommand("UPDATE Phong SET TenPhong=(@ten) WHERE ID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@ten", TenPhong);
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete()
        {
            using (SqlConnection con = DB.GetConnection())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Phong WHERE ID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
