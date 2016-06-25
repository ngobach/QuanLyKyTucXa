using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LapTrinhCSharp.Models;

namespace LapTrinhCSharp.Forms
{
    public partial class FormQLVatTu : Form
    {
        public FormQLVatTu()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            gridView.DataSource = VatTu.All();
        }

        private VatTu ReadForm()
        {
            var vt = new VatTu {Ten = txtName.Text};
            if (gridView.SelectedRows.Count > 0)
            {
                vt.ID = (int)gridView.SelectedRows[0].Cells["ID"].Value;
            }
            return vt;
        }

        private void LoadFormData()
        {
            if (gridView.SelectedRows.Count == 0)
                return;
            txtName.Text = gridView.SelectedRows[0].Cells["Ten"].Value.ToString() ;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ReadForm().Create();
                MessageBox.Show("Thêm mới thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                if (exc.Number == DB.ERR_CONFLICK)
                {
                    MessageBox.Show("Mã vật tư này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ReadForm().Update();
                MessageBox.Show("Cập nhật thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                if (exc.Number == DB.ERR_CONFLICK)
                {
                    MessageBox.Show("Mã vật tư Này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 0) return;
            try
            {
                ReadForm().Delete();
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
