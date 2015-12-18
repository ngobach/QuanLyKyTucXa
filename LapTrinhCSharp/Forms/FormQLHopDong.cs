using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhCSharp
{
    public partial class FormQLHopDong : Form
    {
        public FormQLHopDong()
        {
            InitializeComponent();
        }
        private void LoadCombobox()
        {
            cmbPhong.DataSource = Phong.All();
            cmbPhong.DisplayMember = "TenPhong";
            cmbPhong.ValueMember = "ID";
        }
        private void LoadGrid()
        {
            grid.AutoGenerateColumns = false;
            grid.DataSource = HopDong.All();
        }
        private void LoadListSV()
        {
            if (grid.SelectedRows.Count == 0)
                return;
            HopDong hd = ReadForm();
            lst.DisplayMember = "HoTen";
            lst.ValueMember = "MaSV";
            lst.DataSource = hd.GetSinhVien();
            cmbSV.DisplayMember = "HoTen";
            cmbSV.ValueMember = "MaSV";
            cmbSV.DataSource = hd.GetSinhVienNotIn();
        }
        private void FormQLHopDong_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadGrid();
        }
        private HopDong ReadForm()
        {
            HopDong hd = new HopDong();
            hd.MaHopDong = txtMaHD.Text;
            hd.NgayBatDau = dtp1.Value;
            hd.NgayHetHan = dtp2.Value;
            hd.Phong = (int)cmbPhong.SelectedValue;
            hd.DaKetThuc = chk.Checked;
            return hd;
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string name = grid.Columns[e.ColumnIndex].Name;
            if (name == "DaHetHan")
            {
                if (e.Value.ToString() == "0")
                {
                    e.Value = "Chưa hết hạn";
                }
                else
                {
                    e.Value = "Đã hết hạn";
                }
            }
            else if (name == "DaKetThuc")
            {
                if (e.Value.ToString() == "False")
                {
                    e.Value = "Chưa kết thúc";
                }
                else
                {
                    e.Value = "Đã kết thúc";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ReadForm().Create();
                LoadGrid();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0)
                return;
            try
            {
                HopDong hd = ReadForm();
                hd.MaHopDong = grid.SelectedRows[0].Cells["MaHopDong"].Value.ToString();
                hd.Update();
                LoadGrid();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (grid.SelectedRows.Count == 0)
                return;
            try
            {
                HopDong hd = ReadForm();
                hd.MaHopDong = grid.SelectedRows[0].Cells["MaHopDong"].Value.ToString();
                hd.Delete();
                LoadGrid();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            if (cmbSV.SelectedItem == null) return;
            HopDong hd = ReadForm();
            hd.AddSinhVien(cmbSV.SelectedValue.ToString());
            LoadListSV();
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0) return;
            DataGridViewRow row = grid.SelectedRows[0];
            txtMaHD.Text = row.Cells["MaHopDong"].Value.ToString();
            dtp1.Value = (DateTime)row.Cells["NgayBatDau"].Value;
            dtp2.Value = (DateTime)row.Cells["NgayHetHan"].Value;
            cmbPhong.SelectedValue = (int)row.Cells["MaPhong"].Value;
            chk.Checked = (bool)row.Cells["DaKetThuc"].Value;
            LoadListSV();
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            if (lst.SelectedItem == null) return;
            HopDong hd = ReadForm();
            hd.DeleteSinhVien(lst.SelectedValue.ToString());
            LoadListSV();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            (new FormReportHopDong()).ShowDialog();
        }
    }
}
