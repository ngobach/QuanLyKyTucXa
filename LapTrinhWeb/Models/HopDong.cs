using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using LapTrinhWeb.Models;
using LapTrinhWeb.App_Code;

namespace LapTrinhWeb.Models
{
    public class HopDong
    {
        public string MaHopDong;
        public DateTime NgayBatDau;
        public DateTime NgayHetHan;
        public int Phong;
        public bool DaKetThuc;

        public static DataTable Chuakt()
        { 
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("WEB_HopDong_Chuakt", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            return table;
        }

        public static DataTable Dakt()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("WEB_HopDong_Dakt", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            return table;
        }

        public static DataTable All()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("HopDong_DanhSach", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        public static DataTable List() {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("WEB_HopDong_Select_MaHD", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public static int TongSo()
        {
            SqlCommand cmd = new SqlCommand("WEB_HopDong_Tongso", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            return (Int32)cmd.ExecuteScalar();
        }
        public static int SoHetHan()
        {
            SqlCommand cmd = new SqlCommand("WEB_HopDong_Sohethan", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            return (Int32)cmd.ExecuteScalar();
        }
        public static int SoKetThuc()
        {
            SqlCommand cmd = new SqlCommand("WEB_HopDong_Sokt", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            return (Int32)cmd.ExecuteScalar();
        }

        public DataTable GetSinhVien()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("WEB_HopDong_GetSV", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public DataTable GetSinhVienNotIn()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("WEB_HopDong_GetSVNotIn", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public void AddSinhVien(String masv)
        {
            SqlCommand cmd = new SqlCommand("WEB_HopDong_AddSV", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.ExecuteNonQuery();
        }
        public void DeleteSinhVien(String masv)
        {
            SqlCommand cmd = new SqlCommand("WEB_HopDong_DeleteSV", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.ExecuteNonQuery();
        }

        public static HopDong Find(String mahd)
        {
            SqlCommand cmd = new SqlCommand("WEB_HopDong_Find", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", mahd);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;
            HopDong hopdong = new HopDong();
            hopdong.MaHopDong = (String)reader["MaHopDong"];
            hopdong.NgayBatDau = (DateTime)reader["NgayBatDau"];
            hopdong.NgayHetHan = (DateTime)reader["NgayHetHan"];
            hopdong.Phong = (Int32)reader["Phong"];
            hopdong.DaKetThuc = (Boolean)reader["DaKetThuc"];
            reader.Close();
            return hopdong;
        }
        public void Insert()
        {
            SqlCommand cmd = new SqlCommand("WEB_HopDong_Insert", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            cmd.Parameters.AddWithValue("@ngaybd", NgayBatDau);
            cmd.Parameters.AddWithValue("@ngayhh", NgayHetHan);
            cmd.Parameters.AddWithValue("@phong", Phong);
            cmd.Parameters.AddWithValue("@dakt", DaKetThuc);
            cmd.ExecuteNonQuery();
        }

        public void Update()
        {
            SqlCommand cmd = new SqlCommand("WEB_HopDong_Update", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            cmd.Parameters.AddWithValue("@ngaybd", NgayBatDau);
            cmd.Parameters.AddWithValue("@ngayhh", NgayHetHan);
            cmd.Parameters.AddWithValue("@phong", Phong);
            cmd.Parameters.AddWithValue("@dakt", DaKetThuc);
            cmd.ExecuteNonQuery();
        }
        public void Delete()
        {
            SqlCommand cmd = new SqlCommand("WEB_HopDong_Delete", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            cmd.ExecuteNonQuery();
        }
    }
}
