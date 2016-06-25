using System;
using System.Data;
using System.Data.SqlClient;

namespace LapTrinhCSharp.Models
{
    public class Phong
    {
        public int ID { get; set; }
        public int MaNha { get; set; }
        public string TenPhong { get; set; }
        public int ToiDa { get; set; }

        public static DataTable All(bool onlyFree = false)
        {
            string query = "SELECT Phong.*, Nha.Ten as Nha FROM Phong JOIN Nha ON Phong.MaNha = Nha.ID";
            if (onlyFree)
                query += " WHERE (SELECT COUNT(*) FROM HopDong WHERE HopDong.Phong = Phong.ID AND HopDong.DaKetThuc = 1) < Phong.ToiDa";
            var table = new DataTable();
            using (var con = DB.GetConnection())
            using (var cmd = new SqlCommand(query, con))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(table);
            }
            return table;
        }
        public void Create()
        {
            using (var con = DB.GetConnection())
            using (var cmd = new SqlCommand("INSERT INTO Phong (MaNha,Ten,ToiDa) VALUES (@nha, @ten, @toida)",con))
            {
                cmd.Parameters.AddWithValue("@nha", MaNha);
                cmd.Parameters.AddWithValue("@ten", TenPhong);
                cmd.Parameters.AddWithValue("@toida", ToiDa);
                cmd.ExecuteNonQuery();
            }
        }
        public void Update()
        {
            using (var con = DB.GetConnection())
            using (var cmd = new SqlCommand("UPDATE Phong SET Ten=@ten, ToiDa=@toida,MaNha=@nha WHERE ID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@nha", MaNha);
                cmd.Parameters.AddWithValue("@ten", TenPhong);
                cmd.Parameters.AddWithValue("@toida", ToiDa);
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete()
        {
            using (var con = DB.GetConnection())
            using (var cmd = new SqlCommand("DELETE FROM Phong WHERE ID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable DSVatTu()
        {
            var table = new DataTable();
            using (var con = DB.GetConnection())
            using (var adapter = new SqlDataAdapter("SELECT CTPhong.*, VatTu.Ten AS VatTu FROM CTPhong JOIN VatTu ON CTPhong.MaVatTu = VatTu.ID WHERE MaPhong=" + ID, con))
                adapter.Fill(table);
            return table;
        }

        public void ThemVatTu(int id, int count, string note)
        {
            using (var con = DB.GetConnection())
            using (var cmd = new SqlCommand("INSERT INTO CTPhong (MaPhong, MaVatTu, SoLuong, GhiChu) VALUES (@phong,@vattu,@sl, @ghichu)", con))
            {
                cmd.Parameters.AddWithValue("@phong", ID);
                cmd.Parameters.AddWithValue("@vattu", id);
                cmd.Parameters.AddWithValue("@sl", count);
                cmd.Parameters.AddWithValue("@ghichu", note);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public class ChiTietVatTu
    {
        public int ID { get; set; }
        public int MaPhong { get; set; }
        public int MaVatTu { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }

        public void Fetch()
        {
            using (var con = DB.GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM CTPhong WHERE ID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", ID);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MaPhong = (int) reader["MaPhong"];
                        MaVatTu = (int) reader["MaVatTu"];
                        SoLuong = (int) reader["SoLuong"];
                        GhiChu = (string) reader["GhiChu"];
                    }
                }
            }
        }

        public void Update()
        {
            if (ID == 0) throw new Exception("WTF? ID = 0");
            using (var con = DB.GetConnection())
            using (var cmd = new SqlCommand("UPDATE CTPhong SET SoLuong=@sl, GhiChu=@ghichu WHERE ID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@sl", SoLuong);
                cmd.Parameters.AddWithValue("@ghichu", GhiChu);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete()
        {

            if (ID == 0) throw new Exception("WTF? ID = 0");
            using (var con = DB.GetConnection())
            using (var cmd = new SqlCommand("DELETE FROM CTPhong WHERE ID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
