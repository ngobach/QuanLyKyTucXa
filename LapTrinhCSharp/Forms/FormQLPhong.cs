using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LapTrinhCSharp.Models;

namespace LapTrinhCSharp.Forms
{
    public partial class FormQLPhong : Form
    {
        public FormQLPhong()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cbNha.DataSource = Models.Nha.All();
            cbNha.DisplayMember = "Ten";
            cbNha.ValueMember = "ID";

            cbVT.DisplayMember = "Ten";
            cbVT.ValueMember = "ID";
            cbVT.DataSource = VatTu.All();

            lstVT.DisplayMember = "VatTu";
            lstVT.ValueMember = "ID";
            

            LoadGrid();
        }
        private void LoadGrid()
        {
            gridView.DataSource = Phong.All(chkFree.Checked);
        }

        private Phong FormData
        {
            get
            {
                var p = new Phong { TenPhong = txtName.Text, ToiDa = Convert.ToInt32(txtToiDa.Text), MaNha = (int)cbNha.SelectedValue};
                if (gridView.SelectedRows.Count > 0)
                {
                    p.ID = (int)gridView.SelectedRows[0].Cells["ID"].Value;
                }
                return p;
            }
        }

        private void LoadFormData()
        {
            if (gridView.SelectedRows.Count == 0)
                return;
            txtName.Text = gridView.SelectedRows[0].Cells["Ten"].Value.ToString();
            txtToiDa.Text = gridView.SelectedRows[0].Cells["ToiDa"].Value.ToString();
            cbNha.SelectedValue = Convert.ToInt32(gridView.SelectedRows[0].Cells["MaNha"].Value.ToString());
            LoadVatTu();
        }

        private void LoadVatTu()
        {
            if (gridView.SelectedRows.Count == 0) return;
            lstVT.DataSource = FormData.DSVatTu();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FormData.Create();
                MessageBox.Show("Thêm mới thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                if (exc.Number == DB.ERR_CONFLICK)
                {
                    MessageBox.Show("Mã phòng Này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                FormData.Update();
                MessageBox.Show("Cập nhật thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException exc)
            {
                if (exc.Number == DB.ERR_CONFLICK)
                {
                    MessageBox.Show("Mã phòng Này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                FormData.Delete();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnVTAdd_Click(object sender, EventArgs e)
        {
            FormData.ThemVatTu((int) cbVT.SelectedValue, Convert.ToInt32(txtCount.Text), txtNote.Text);
            LoadVatTu();
        }

        private void lstVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVT.SelectedValue == null)
            {
                txtCount.Text = txtNote.Text = "";
                return;
            }
            var id = (int) lstVT.SelectedValue;
            var ct = new ChiTietVatTu {ID = id};
            ct.Fetch();
            txtCount.Text = ct.SoLuong.ToString();
            txtNote.Text = ct.GhiChu;
        }

        private void btnVTUpdate_Click(object sender, EventArgs e)
        {
            if (lstVT.SelectedValue == null) return;
            var id = (int)lstVT.SelectedValue;
            var ct = new ChiTietVatTu { ID = id, SoLuong = Convert.ToInt32(txtCount.Text), GhiChu = txtNote.Text};
            ct.Update();
            LoadVatTu();
        }

        private void btVTDelete_Click(object sender, EventArgs e)
        {
            if (lstVT.SelectedValue == null) return;
            var id = (int)lstVT.SelectedValue;
            var ct = new ChiTietVatTu { ID = id};
            ct.Delete();
            LoadVatTu();
        }
    }
}
