using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LapTrinhWeb.App_Code;
using System.Data.SqlClient;
using System.Data;
using LapTrinhWeb.Models;

namespace LapTrinhWeb
{
    public partial class CTHopDong : BasePage
    {
        private void LoadDropSinhVien()
        {
            HopDong hopdong = new HopDong();
            hopdong.MaHopDong = txtMaHD.Text;
            DataTable table = hopdong.GetSinhVienNotIn();
            dropSV.DataSource = table;
            dropSV.DataValueField = "MaSV";
            dropSV.DataTextField = "HoTen";
            dropSV.DataBind();
        }

        private void LoadDropPhong(int except)
        {
            DataTable table = DBPhong.SelectEmpty(except);
            dropPhong.DataSource = table;
            dropPhong.DataValueField = "ID";
            dropPhong.DataTextField = "TenPhong";
            dropPhong.DataBind();
        }

        private void LoadListSV()
        {
            HopDong hopdong = HopDong.Find(txtMaHD.Text);
            lstSinhVien.DataSource = hopdong.GetSinhVien();
            lstSinhVien.DataTextField = "HoTen";
            lstSinhVien.DataValueField = "MaSV";
            lstSinhVien.DataBind();
        }

        private void LoadData(HopDong hopdong)
        {
            txtMaHD.Text = hopdong.MaHopDong;
            txtNgayBD.Text = hopdong.NgayBatDau.ToString("yyyy-MM-dd");
            txtNgayHH.Text = hopdong.NgayHetHan.ToString("yyyy-MM-dd");
            chkKetThuc.Checked = hopdong.DaKetThuc;
            dropPhong.SelectedValue = Convert.ToString(hopdong.Phong);
        }

        private HopDong GetData()
        {
            HopDong hopdong = new HopDong();
            hopdong.MaHopDong = txtMaHD.Text;
            hopdong.NgayBatDau = DateTime.Parse(txtNgayBD.Text);
            hopdong.NgayHetHan = DateTime.Parse(txtNgayHH.Text);
            hopdong.DaKetThuc = chkKetThuc.Checked;
            hopdong.Phong = Convert.ToInt32(dropPhong.SelectedValue);
            return hopdong;
        }
        private void InsertMode()
        {
            txtMaHD.Enabled = true;
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnSVAdd.Enabled = false;
            btnSVDelete.Enabled = false;
        }
        private void UpdateMode()
        {
            txtMaHD.Enabled = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnSVAdd.Enabled = true;
            btnSVDelete.Enabled = true;

            LoadDropSinhVien();
            LoadListSV();
        }

        private bool ValidateForm()
        {
            DateTime datetime;
            if (txtMaHD.Text == "")
            {
                alert = new Alert("warning", "Cảnh báo", "Không được để trống Mã hợp đồng");
                return false;
            }
            else if (!DateTime.TryParse(txtNgayBD.Text, out datetime))
            {
                alert = new Alert("warning", "Cảnh báo", "Ngày bắt đầu không hợp lệ");
                return false;
            }
            else if (!DateTime.TryParse(txtNgayHH.Text, out datetime))
            {
                alert = new Alert("warning", "Cảnh báo", "Ngày hết hạn không hợp lệ");
                return false;
            }
            else if (dropPhong.SelectedIndex == -1)
            {
                alert = new Alert("warning", "Cảnh báo", "Vui lòng chọn phòng!");
                return false;
            }
            return true;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Login required
            if (!HttpContext.Current.IsDebuggingEnabled && Session["Username"] == null)
            {
                Response.BufferOutput = true;
                Response.Redirect("~/Login.aspx");
                return;
            }
            if (!IsPostBack)
            {
                // Load data
                HopDong hopdong;
                if (Request.QueryString["id"] != null && (hopdong = HopDong.Find(Request.QueryString["id"]))!=null)
                {
                    LoadData(hopdong);
                    LoadDropPhong(hopdong.Phong);
                    UpdateMode();
                }
                else
                {
                    btnUpdate.Visible = false;
                    LoadDropPhong(0);
                    InsertMode();
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            HopDong hopdong = GetData();
            try { 
                hopdong.Insert();
                UpdateMode();
                alert = new Alert("success", "Thành công", String.Format("Hợp đồng \"{0}\" đã được thêm vào", hopdong.MaHopDong));
            }
            catch (SqlException exc)
            {
                alert = DB.ExceptionInfo(exc);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            HopDong hopdong = GetData();
            try
            {
                hopdong.Update();
                btnUpdate.Visible = true;
                btnAdd.Visible = false;
                alert = new Alert("success", "Thành công", String.Format("Hợp đồng \"{0}\" đã được cập nhật", hopdong.MaHopDong));
            }
            catch (SqlException exc)
            {
                alert = DB.ExceptionInfo(exc);
            }
        }

        protected void btnSVAdd_Click(object sender, EventArgs e)
        {
            if (dropSV.SelectedIndex == -1)
            {
                alert = new Alert("warning", "Cảnh báo", "Chưa chọn sinh viên cần thêm");
                return;
            }
            try
            {
                HopDong hopdong = HopDong.Find(txtMaHD.Text);
                hopdong.AddSinhVien(dropSV.SelectedValue);
                LoadListSV();
                LoadDropSinhVien();
                alert = new Alert("success", "Thành công", String.Format("Sinh viên {0} đã được thêm vào!",dropSV.Text));
            }
            catch (SqlException exc)
            {
                alert = DB.ExceptionInfo(exc);
            }
        }

        protected void btnSVDelete_Click(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex == -1)
            {
                alert = new Alert("warning", "Cảnh báo", "Chưa chọn sinh viên cần xóa");
                return;
            }
            try
            {
                HopDong hopdong = HopDong.Find(txtMaHD.Text);
                hopdong.DeleteSinhVien(lstSinhVien.SelectedValue);
                LoadListSV();
                LoadDropSinhVien();
                alert = new Alert("success", "Thành công", "Xóa thành công");
            }
            catch (SqlException exc)
            {
                alert = DB.ExceptionInfo(exc);
            }
        }

    }
}