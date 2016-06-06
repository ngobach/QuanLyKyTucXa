using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace LapTrinhWeb.App_Code
{
    public class DBSinhVien : DB
    {
        public static DataTable SelectAll()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SinhVien_DanhSach", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }


        public static void Insert(String masv, String hoten, String sdt, DateTime ngaysinh, String gioitinh, String quequan, String lop, String khoa)
        {
            SqlCommand cmd = new SqlCommand("WEB_Sinhvien_Insert", GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@quequan", quequan);
            cmd.Parameters.AddWithValue("@lop", lop);
            cmd.Parameters.AddWithValue("@khoa", khoa);
            cmd.ExecuteNonQuery();
        }

        public static void Update(String old, String masv, String hoten, String sdt, DateTime ngaysinh, String gioitinh, String quequan, String lop, String khoa)
        {
            SqlCommand cmd = new SqlCommand("WEB_Sinhvien_Update", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@old", old);
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@quequan", quequan);
            cmd.Parameters.AddWithValue("@lop", lop);
            cmd.Parameters.AddWithValue("@khoa", khoa);
            cmd.ExecuteNonQuery();
        }

        public static void Delete(String masv)
        {
            SqlCommand cmd = new SqlCommand("WEB_Sinhvien_Delete", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.ExecuteNonQuery();
        }

    }
}