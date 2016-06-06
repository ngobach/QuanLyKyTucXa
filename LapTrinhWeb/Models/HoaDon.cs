﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using LapTrinhWeb.App_Code;

namespace LapTrinhWeb.Models
{
    [Serializable]
    public class HoaDon
    {
        public int ID, Nam, Thang;
        public double TienPhong,TienDien,TienNuoc,PhuPhi;
        public string MaHopDong,ChiTiet = "";
        public bool DaThanhToan;

        public static DataTable All(String mahd = "")
        {
            DataTable table = new DataTable();
            SqlCommand cmd;
            if (mahd == "")
            {
                cmd = new SqlCommand("WEB_Hoadon_Select", DB.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd = new SqlCommand("WEB_Hoadon_Select_MaHD", DB.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahd", mahd);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        public static int TongSo()
        {
            SqlCommand cmd = new SqlCommand("WEB_Hoadon_Select_Tongso", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            return (Int32)cmd.ExecuteScalar();
        }

        public static int ChuaTT()
        {
            SqlCommand cmd = new SqlCommand("WEB_Hoadon_Select_ChuaTT", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            return (Int32)cmd.ExecuteScalar();
        }
        public HoaDon()
        { 
        }
        public HoaDon(String mahd, int nam, int thang)
        {
            MaHopDong = mahd;
            Nam = nam;
            Thang = thang;
        }

        public static HoaDon Find(int id)
        {
            SqlCommand cmd = new SqlCommand("WEB_Hoadon_Select_Find", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;
            HoaDon hoadon = new HoaDon();
            hoadon.ID = (int)reader["ID"];
            hoadon.MaHopDong = (String)reader["MaHopDong"];
            hoadon.Nam = (int)reader["Nam"];
            hoadon.Thang = (int)reader["Thang"];
            hoadon.TienPhong = (double)reader["TienPhong"];
            hoadon.TienDien = (double)reader["TienDien"];
            hoadon.TienNuoc = (double)reader["TienNuoc"];
            hoadon.PhuPhi = (double)reader["PhuPhi"];
            if (!(reader["ChiTiet"] is DBNull))
                hoadon.ChiTiet = (String)reader["ChiTiet"];
            else
                hoadon.ChiTiet = "";
            hoadon.DaThanhToan = (Boolean)reader["DaThanhToan"];
            reader.Close();
            return hoadon;
        }

        public void Insert()
        {
            SqlCommand cmd = new SqlCommand(
                "WEB_Hoadon_Insert", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", MaHopDong);
            cmd.Parameters.AddWithValue("@nam", Nam);
            cmd.Parameters.AddWithValue("@thang", Thang);
            cmd.Parameters.AddWithValue("@tienphong", TienPhong);
            cmd.Parameters.AddWithValue("@tiendien", TienDien);
            cmd.Parameters.AddWithValue("@tiennuoc", TienNuoc);
            cmd.Parameters.AddWithValue("@phuphi", PhuPhi);
            cmd.Parameters.AddWithValue("@chitiet", DBNull.Value);
            cmd.Parameters.AddWithValue("@datt", DaThanhToan);
            ID = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Update()
        {
            SqlCommand cmd = new SqlCommand("WEB_Hoadon_Update", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@tienphong", TienPhong);
            cmd.Parameters.AddWithValue("@tiendien", TienDien);
            cmd.Parameters.AddWithValue("@tiennuoc", TienNuoc);
            cmd.Parameters.AddWithValue("@phuphi", PhuPhi);
            cmd.Parameters.AddWithValue("@chitiet", ChiTiet);
            cmd.Parameters.AddWithValue("@datt", DaThanhToan);
            cmd.ExecuteNonQuery();
        }

        public void Delete()
        {
            SqlCommand cmd = new SqlCommand("WEB_Hoadon_Delete", DB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
        }
    }
}
