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
            SqlCommand cmd = new SqlCommand("INSERT INTO SinhVien VALUES (@masv,@hoten,@sdt,@ngaysinh,@gioitinh,@quequan,@lop,@khoa)",GetConnection());
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@quequan", quequan);
            cmd.Parameters.AddWithValue("@lop", lop);
            cmd.Parameters.AddWithValue("@khoa", lop);
            cmd.ExecuteNonQuery();
        }

        public static void Update(String old, String masv, String hoten, String sdt, DateTime ngaysinh, String gioitinh, String quequan, String lop, String khoa)
        {
            SqlCommand cmd = new SqlCommand("UPDATE SinhVien SET MaSV=@masv,HoTen=@hoten,SoDienThoai=@sdt,NgaySinh=@ngaysinh,GioiTinh=@gioitinh,QueQuan=@quequan, Lop=@lop, Khoa=@khoa WHERE MaSV=@old", DB.GetConnection());
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
            SqlCommand cmd = new SqlCommand("DELETE FROM [SinhVien] WHERE MaSV=@masv", DB.GetConnection());
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.ExecuteNonQuery();
        }

    }
}