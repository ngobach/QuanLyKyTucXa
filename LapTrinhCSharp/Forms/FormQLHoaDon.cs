using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LapTrinhCSharp.Forms
{
    public partial class FormQLHoaDon : Form
    {
        public FormQLHoaDon()
        {
            InitializeComponent();
        }

        private void QLHopDong_Load(object sender, EventArgs e)
        {
            rdTatca.Checked = true;
            loadCombo();
            loadTatca();
        }


        private void loadTatca()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT *,(TienPhong+TienDien+TienNuoc+PhuPhi) AS Tongtien FROM HoaDon", DB.GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            rdTatca.Checked = true;
        }

        private void loadChuaTT()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT *,(TienPhong+TienDien+TienNuoc+PhuPhi) AS Tongtien FROM HoaDon WHERE dathanhtoan = 'false'", DB.GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
        }

        private void loadDaTT()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT *,(TienPhong+TienDien+TienNuoc+PhuPhi) AS Tongtien FROM HoaDon WHERE dathanhtoan='true'", DB.GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
        }


        private void loadCombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HopDong", DB.GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboMa.DataSource = dt;
            comboMa.DisplayMember = "MaHopDong";
            comboMa.ValueMember = "MaHopDong";
        }

        private void loadform()
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = Grid.SelectedRows[0];
            txtPhuphi.Text = row.Cells["Phuphi"].Value.ToString();
            txtTiendien.Text = row.Cells["Tiendien"].Value.ToString();
            txtTiennuoc.Text = row.Cells["Tiennuoc"].Value.ToString();
            txtTienphong.Text = row.Cells["Tienphong"].Value.ToString();
            comboMa.SelectedValue = row.Cells["MaHopDong"].Value;
            txtNam.Text = row.Cells["Nam"].Value.ToString();
            txtThang.Text = row.Cells["Thang"].Value.ToString();
            if (row.Cells["DaThanhToan"].Value.ToString().ToLower().Equals("true"))
            {
                checkTT.Checked = true;
            }
            else
            {
                checkTT.Checked = false;
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            loadform();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Hoadon (MaHopDong, Thang, Nam, Tienphong, Tiennuoc, Tiendien, phuphi, dathanhtoan, chitiet) VALUES (@mahd,@thang,@nam,@tienphong,@tiennuoc,@tiendien,@phuphi,@datt,@chitiet)", DB.GetConnection());
            cmd.Parameters.AddWithValue("@mahd", comboMa.SelectedValue);
            cmd.Parameters.AddWithValue("@thang", txtThang.Text);
            cmd.Parameters.AddWithValue("@nam", txtNam.Text);
            cmd.Parameters.AddWithValue("@tienphong", txtTienphong.Text);
            cmd.Parameters.AddWithValue("@tiennuoc", txtTiennuoc.Text);
            cmd.Parameters.AddWithValue("@tiendien", txtTiendien.Text);
            cmd.Parameters.AddWithValue("@phuphi", txtPhuphi.Text);
            cmd.Parameters.AddWithValue("@chitiet", DBNull.Value);
            cmd.Parameters.AddWithValue("@datt", checkTT.Checked);
            try
            {
                cmd.ExecuteNonQuery();
                loadTatca();
            }
            catch
            {
                MessageBox.Show("Hóa đơn này đã tồn tại!", "Thông báo");
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string mahd = Grid.SelectedRows[0].Cells["MaHopDong"].Value.ToString();
            string nam = Grid.SelectedRows[0].Cells["nam"].Value.ToString();
            string thang = Grid.SelectedRows[0].Cells["thang"].Value.ToString();
            SqlCommand cmd = new SqlCommand("UPDATE HoaDon SET MaHopDong=@mahd, Thang=@thang, Nam=@nam, Tienphong=@tienphong, Tiennuoc=@tiennuoc, Tiendien=@tiendien, Phuphi=@phuphi, dathanhtoan=@datt WHERE MaHopDong=@mahdcu AND Thang=@thangcu AND Nam=@namcu",DB.GetConnection());
            cmd.Parameters.AddWithValue("@mahd", comboMa.SelectedValue);
            cmd.Parameters.AddWithValue("@thang", txtThang.Text);
            cmd.Parameters.AddWithValue("@nam", txtNam.Text);
            cmd.Parameters.AddWithValue("@tienphong", txtTienphong.Text);
            cmd.Parameters.AddWithValue("@tiennuoc", txtTiennuoc.Text);
            cmd.Parameters.AddWithValue("@tiendien", txtTiendien.Text);
            cmd.Parameters.AddWithValue("@phuphi", txtPhuphi.Text);
            cmd.Parameters.AddWithValue("@datt", checkTT.Checked);
            cmd.Parameters.AddWithValue("@mahdcu", mahd);
            cmd.Parameters.AddWithValue("@thangcu", thang);
            cmd.Parameters.AddWithValue("@namcu", nam);
            cmd.ExecuteNonQuery();
            loadTatca();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = Grid.SelectedRows[0].Cells["ID"].Value.ToString();
            SqlCommand cmd = new SqlCommand("DELETE FROM Hoadon WHERE id=@id",DB.GetConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            loadTatca();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            (new FormReportHoaDon()).ShowDialog();
        }

        private void rdTatca_Click(object sender, EventArgs e)
        {
            rdTatca.Checked = true;
            loadTatca();
        }

        private void rdChuaTT_Click(object sender, EventArgs e)
        {
            rdChuaTT.Checked = true;
            loadChuaTT();
        }

        private void rdDaTT_Click(object sender, EventArgs e)
        {
            rdDaTT.Checked = true;
            loadDaTT();
        }



    }
}
