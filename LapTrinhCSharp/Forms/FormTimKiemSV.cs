using System;
using System.Windows.Forms;
using LapTrinhCSharp.Models;

namespace LapTrinhCSharp.Forms
{
    public partial class FormTimKiemSV : Form
    {
        public FormTimKiemSV()
        {
            InitializeComponent();
        }

        private bool ExactSearch => radExcact.Checked;

        public string SelectedItem { get; private set; }
        /**
         * Nạp dữ liệu từ SQL vào DataGridView
         * 
         **/
        private void LoadGrid()
        {
            gridView.DataSource = SinhVien.All();
        }

        /**
         * Lấy dữ liệu từ datagridview và nạp vào form
         *
         **/
        private void LoadFormData()
        {
            if (gridView.SelectedRows.Count == 0)
                return;
            var row = gridView.SelectedRows[0];
            SelectedItem = txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtQueQuan.Text = row.Cells["QueQuan"].Value.ToString();
            txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
            txtKhoa.Text = row.Cells["Khoa"].Value.ToString();
            txtLop.Text = row.Cells["Lop"].Value.ToString();
            txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            txtNgaySinh.Text = ((DateTime)row.Cells["NgaySinh"].Value).ToString("dd/MM/yyyy");
        }

        private void FormTimKiemSV_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            gridView.DataSource = SinhVien.Search(txtFHoTen.Text, ExactSearch);
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            LoadFormData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm kiếm chính xác sẽ tìm những sinh viên có họ tên khớp với nhập vào.\n" +
                            "Tìm kiểm một phần sẽ tìm những sinh viên có họ tên chỉ khớp một phần với nội dung tìm kiếm!", "Giải thích", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
