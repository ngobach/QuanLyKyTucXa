using System.Data;
using System.Data.SqlClient;

namespace LapTrinhCSharp.Models
{
    public class VatTu
    {

        public int ID;
        public string Ten;

        public static DataTable All()
        {
            var table = new DataTable();
            using (var con = DB.GetConnection())
            using (var cmd = new SqlCommand("SELECT * FROM VatTu", con))
            using (var adapter = new SqlDataAdapter(cmd))
                adapter.Fill(table);
            return table;
        }


        public void Create()
        {
            using (var con = DB.GetConnection())
            using (var cmd = new SqlCommand("INSERT INTO VatTu (Ten) VALUES (@ten)",con))
            {
                cmd.Parameters.AddWithValue("@ten", Ten);
                cmd.ExecuteNonQuery();
            }
        }
        public void Update()
        {
            using (SqlConnection con = DB.GetConnection())
            using (SqlCommand cmd = new SqlCommand("UPDATE VatTu SET Ten=@ten WHERE ID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@ten", Ten);
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete()
        {
            using (SqlConnection con = DB.GetConnection())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM VatTu WHERE ID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
            }
        }
        
    }
}
