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
    public partial class FormQLPhong : Form
    {
        public FormQLPhong()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Gọi hàm nạp dữ liệu vào datagridview
            LoadGrid();
        }
        // Hàm lấy dữ liệu từ SQL và nạp vào DataGridView
        private void LoadGrid()
        {
            // Gán datasource cho gridView
            gridView.DataSource = Phong.All();
        }

        // Hàm đọc giá trị từ Form
        private Phong ReadForm()
        {
            Phong p = new Phong();
            p.TenPhong = txtName.Text;
            if (gridView.SelectedRows.Count > 0)
            {
                // gán tên phòng
                p.ID = (int)gridView.SelectedRows[0].Cells["ID"].Value;
            }
            return p;
        }

        /**
         * Lấy dữ liệu từ datagridview và nạp vào form
         *
         **/
        private void LoadFormData()
        {
            // Kiểm tra xem có dòng nào trong datagridview
            // Đang được chọn không
            // Nếu không thì dừng hàm
            if (gridView.SelectedRows.Count == 0)
                return;
            // Gán giá trị cho ô Tên Phòng
            txtName.Text = gridView.SelectedRows[0].Cells["TenPhong"].Value.ToString() ;
        }

        // Hàm xử lý sự kiện click nút thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Đọc dữ liệu từ form và insert vào cơ sở dữ liệu
                ReadForm().Create();
                MessageBox.Show("Thêm mới thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                // Xử lý khi gặp lỗi
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

        // Hàm xửa lý sự kiện click vào button Sửa
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Đọc dữ liệu từ form và nạp vào SQL
                ReadForm().Update();
                MessageBox.Show("Cập nhật thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                // Xử lý khi gặp lỗi
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
        
        // Hàm xử lý sự kiện click button xóa form
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Đọc dữ liệu từ form và gọi xóa trong SQL
                ReadForm().Delete();
                MessageBox.Show("Xóa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                // Xử lý khi gặp lỗi
                MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // xử lý sự kiện khi người dùng chọn 1 dòng trong CSDL
        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            // Gọi hàm nạp dữ liệu từ DataGridView vào Form
            LoadFormData();
        }

    }
}
