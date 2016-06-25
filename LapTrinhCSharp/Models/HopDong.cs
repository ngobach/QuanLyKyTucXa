using System;
using System.Data;
using System.Data.SqlClient;
using LapTrinhCSharp.MainDatasetTableAdapters;

namespace LapTrinhCSharp.Models
{
    public class HopDong
    {
        public string MaHopDong;
        public string SinhVien;
        public int Phong;
        public DateTime NgayBatDau;
        public DateTime NgayHetHan;
        public bool DaKetThuc;
        
        public static DataTable All()
        {
            return new HopDongTableAdapter().GetData();
        }

        public void Create()
        {
            using (
                var cmd = new SqlCommand("INSERT INTO HopDong VALUES (@mahd,@sinhvien,@phong,@ngaybd,@ngayhh,@dakt)",
                    DB.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@mahd", MaHopDong);
                cmd.Parameters.AddWithValue("@sinhvien", SinhVien);
                cmd.Parameters.AddWithValue("@phong", Phong);
                cmd.Parameters.AddWithValue("@ngaybd", NgayBatDau);
                cmd.Parameters.AddWithValue("@ngayhh", NgayHetHan);
                cmd.Parameters.AddWithValue("@dakt", DaKetThuc);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update()
        {
            using (
                var cmd = new SqlCommand("UPDATE HopDong SET SinhVien=@sinhvien,Phong=@phong,NgayBatDau=@ngaybd,NgayHetHan=@ngayhh,DaKetThuc=@dakt WHERE MaHopDong=@mahd",
                    DB.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@mahd", MaHopDong);
                cmd.Parameters.AddWithValue("@sinhvien", SinhVien);
                cmd.Parameters.AddWithValue("@phong", Phong);
                cmd.Parameters.AddWithValue("@ngaybd", NgayBatDau);
                cmd.Parameters.AddWithValue("@ngayhh", NgayHetHan);
                cmd.Parameters.AddWithValue("@dakt", DaKetThuc);
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete()
        {
            var cmd = new SqlCommand("DELETE FROM HopDong WHERE MaHopDong=@mahd", DB.GetConnection());
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            cmd.ExecuteNonQuery();
        }
    }
}
