using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LapTrinhCSharp
{
    public partial class FormTimKiemSV : Form
    {
        private DataTable table;

        public FormTimKiemSV()
        {
            InitializeComponent();
        }
        /**
         * Nạp dữ liệu từ SQL vào DataGridView
         * 
         **/
        private void LoadGrid()
        {
            gridView.DataSource = table = SinhVien.All();
        }

        /**
         * Lấy dữ liệu từ datagridview và nạp vào form
         *
         **/
        private void LoadFormData()
        {
            if (gridView.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = gridView.SelectedRows[0];
            txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtQueQuan.Text = row.Cells["QueQuan"].Value.ToString();
            txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
            txtKhoa.Text = row.Cells["Khoa"].Value.ToString();
            txtLop.Text = row.Cells["Lop"].Value.ToString();
            txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            txtNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
        }

        private void FormTimKiemSV_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            List<String> filters = new List<string>();
            if (txtFMaSV.Text.Length > 0)
                filters.Add(String.Format("MaSV LIKE '*{0}*'", Utils.EscapeLikeValue(txtFMaSV.Text)));
            if (txtFHoTen.Text.Length > 0)
                filters.Add(String.Format("HoTen LIKE '*{0}*'", Utils.EscapeLikeValue(txtFHoTen.Text)));
            DataView dataView = table.DefaultView;
            dataView.RowFilter = String.Join(" AND ", filters.ToArray());
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            LoadFormData();
        }
    }
}
