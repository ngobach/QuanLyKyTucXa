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
    public partial class FormQLSinhVien : Form
    {
        public FormQLSinhVien()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            gridView.DataSource = SinhVien.All();

        }

        private SinhVien ReadForm()
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = txtMaSV.Text;
            sv.HoTen = txtHoTen.Text;
            sv.SoDienThoai = txtSDT.Text;
            sv.GioiTinh = radNam.Checked ? "Nam" : "Nu";
            sv.QueQuan = txtQueQuan.Text;
            sv.Lop = txtLop.Text;
            sv.Khoa = txtKhoa.Text;
            sv.NgaySinh = datePicker.Value;
            return sv;
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
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
            txtQueQuan.Text = row.Cells["QueQuan"].Value.ToString();
            txtLop.Text = row.Cells["Lop"].Value.ToString();
            txtKhoa.Text = row.Cells["Khoa"].Value.ToString();
            txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            if (row.Cells["GioiTinh"].Value.ToString().ToLower().Equals("nam"))
            {
                radNam.Checked = true;
            } else {
                radNu.Checked = true;
            }
            datePicker.Value = (DateTime)row.Cells["NgaySinh"].Value;
        }

        /**
         * Kiểm tra các giá trị trên form đã đúng chưa
         *
         * @return false: form chưa hoàn chỉnh
         **/
        private bool ValidateForm()
        {
            if (txtMaSV.Text.Length != 10)
            {
                MessageBox.Show("Mã SV phải có 10 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtHoTen.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtQueQuan.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống quê quán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!radNam.Checked && !radNu.Checked)
            {
                MessageBox.Show("Chưa chọn giới tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtKhoa.Text == String.Empty)
            {
                MessageBox.Show("Chưa chọn khoa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtLop.Text == String.Empty)
            {
                MessageBox.Show("Chưa chọn lớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;
            try
            {
                SinhVien sv = ReadForm();
                sv.Create();
                MessageBox.Show("Thêm mới thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                if (exc.Number == DB.ERR_CONFLICK)
                {
                    MessageBox.Show("Mã Sinh Viên Này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;
            try
            {
                SinhVien sv = ReadForm();
                sv.Update();
                MessageBox.Show("Cập nhật thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                if (exc.Number == DB.ERR_CONFLICK)
                {
                    MessageBox.Show("Mã Sinh Viên Này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = ReadForm();
                sv.Delete();
                MessageBox.Show("Xóa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            LoadFormData();
        }

    }
}
