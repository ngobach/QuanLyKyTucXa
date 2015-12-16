﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LapTrinhCSharp
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public string Lop { get; set; }
        public string Khoa { get; set; }

        public static DataTable All()
        {
            DataTable table = new DataTable();
            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [SinhVien]", con);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)){
                    adapter.Fill(table);
                }
            }
            return table;
        }

        public void Create()
        {
            using (SqlConnection con = DB.GetConnection())
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [SinhVien] VALUES (@masv,@hoten,@sdt,@dob,@gt,@quequan,@lop,@khoa)",con))
            {
                cmd.Parameters.AddWithValue("@masv", MaSV);
                cmd.Parameters.AddWithValue("@hoten", HoTen);
                cmd.Parameters.AddWithValue("@sdt", SoDienThoai);
                cmd.Parameters.AddWithValue("@dob", NgaySinh);
                cmd.Parameters.AddWithValue("@gt", GioiTinh);
                cmd.Parameters.AddWithValue("@quequan", QueQuan);
                cmd.Parameters.AddWithValue("@lop", Lop);
                cmd.Parameters.AddWithValue("@khoa", Khoa);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update()
        {
            using (SqlConnection con = DB.GetConnection())
            using (SqlCommand cmd = new SqlCommand("UPDATE [SinhVien] SET HoTen=@hoten,SoDienThoai=@sdt,NgaySinh=@dob,QueQuan=@quequan,Lop=@lop,Khoa=@khoa WHERE MaSV=@masv", con))
            {
                cmd.Parameters.AddWithValue("@masv", MaSV);
                cmd.Parameters.AddWithValue("@hoten", HoTen);
                cmd.Parameters.AddWithValue("@sdt", SoDienThoai);
                cmd.Parameters.AddWithValue("@dob", NgaySinh);
                cmd.Parameters.AddWithValue("@gt", GioiTinh);
                cmd.Parameters.AddWithValue("@quequan", QueQuan);
                cmd.Parameters.AddWithValue("@lop", Lop);
                cmd.Parameters.AddWithValue("@khoa", Khoa);
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete()
        {
            using (SqlConnection con = DB.GetConnection())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM [SinhVien] WHERE MaSV=@masv", con))
            {
                cmd.Parameters.AddWithValue("@masv", MaSV);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
