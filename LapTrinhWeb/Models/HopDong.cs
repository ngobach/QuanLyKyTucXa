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
            SqlCommand cmd = new SqlCommand("SELECT MaHopDong FROM HopDong", DB.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public static int TongSo()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM HopDong", DB.GetConnection());
            return (Int32)cmd.ExecuteScalar();
        }
        public static int SoHetHan()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM HopDong WHERE NgayHetHan < GETDATE()", DB.GetConnection());
            return (Int32)cmd.ExecuteScalar();
        }
        public static int SoKetThuc()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM HopDong WHERE DaKetThuc=1", DB.GetConnection());
            return (Int32)cmd.ExecuteScalar();
        }

        public DataTable GetSinhVien()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT SinhVien.MaSV,SinhVien.HoTen FROM CTHopDong JOIN SinhVien ON CTHopDong.MaSV = SinhVien.MaSV WHERE CTHopDong.MaHopDong=@mahd", DB.GetConnection());
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public DataTable GetSinhVienNotIn()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT SinhVien.MaSV,SinhVien.HoTen FROM SinhVien WHERE MaSV NOT IN (SELECT MaSV FROM CTHopDong WHERE MaHopDong=@mahd)", DB.GetConnection());
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public void AddSinhVien(String masv)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CTHopDong VALUES (@mahd,@masv)", DB.GetConnection());
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.ExecuteNonQuery();
        }
        public void DeleteSinhVien(String masv)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM CTHopDong WHERE MaHopDong=@mahd AND MaSV=@masv", DB.GetConnection());
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.ExecuteNonQuery();
        }

        public static HopDong Find(String mahd)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HopDong WHERE MaHopDong=@mahd", DB.GetConnection());
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
            SqlCommand cmd = new SqlCommand("INSERT INTO HopDong VALUES (@mahd,@ngaybd,@ngayhh,@phong,@dakt)", DB.GetConnection());
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            cmd.Parameters.AddWithValue("@ngaybd", NgayBatDau);
            cmd.Parameters.AddWithValue("@ngayhh", NgayHetHan);
            cmd.Parameters.AddWithValue("@phong", Phong);
            cmd.Parameters.AddWithValue("@dakt", DaKetThuc);
            cmd.ExecuteNonQuery();
        }

        public void Update()
        {
            SqlCommand cmd = new SqlCommand("UPDATE HopDong SET NgayBatDau=@ngaybd,NgayHetHan=@ngayhh,Phong=@phong,DaKetThuc=@dakt WHERE MaHopDong=@mahd", DB.GetConnection());
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            cmd.Parameters.AddWithValue("@ngaybd", NgayBatDau);
            cmd.Parameters.AddWithValue("@ngayhh", NgayHetHan);
            cmd.Parameters.AddWithValue("@phong", Phong);
            cmd.Parameters.AddWithValue("@dakt", DaKetThuc);
            cmd.ExecuteNonQuery();
        }
        public void Delete()
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM HopDong WHERE MaHopDong=@mahd", DB.GetConnection());
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            cmd.ExecuteNonQuery();
        }
    }
}
