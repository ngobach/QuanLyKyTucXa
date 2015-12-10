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
    public partial class CTHoaDon : BasePage
    {
        private void TinhTongTien()
        {
            HoaDon hoadon = (HoaDon)ViewState["HoaDon"];
            txtTongTien.Text = Convert.ToString(hoadon.TienPhong + hoadon.TienDien + hoadon.TienNuoc + hoadon.PhuPhi);
        }
        private void ReadData()
        {
            HoaDon hoadon = (HoaDon)ViewState["HoaDon"];
            hoadon.TienPhong = Convert.ToDouble(txtTPhong.Text);
            hoadon.TienDien = Convert.ToDouble(txtTDien.Text);
            hoadon.TienNuoc = Convert.ToDouble(txtTNuoc.Text);
            hoadon.PhuPhi = Convert.ToDouble(txtPhuPhi.Text);
            hoadon.ChiTiet = txtChiTiet.Text;
            hoadon.DaThanhToan = chkDaThanhToan.Checked;
            ViewState["HoaDon"] = hoadon;
        }


        private bool ValidateForm()
        {
            int tmp;
            if (!Int32.TryParse(txtTPhong.Text, out tmp) || !Int32.TryParse(txtTDien.Text, out tmp) || !Int32.TryParse(txtTNuoc.Text, out tmp) || !Int32.TryParse(txtPhuPhi.Text, out tmp))
            {
                alert = new Alert("warning", "Cảnh báo", "Tiền nhập vào không hợp lệ");
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
                HoaDon hoadon = null;
                if (Request.QueryString["id"] == null || (hoadon = HoaDon.Find(Convert.ToInt32(Request.QueryString["id"])))==null)
                {
                    Response.BufferOutput = true;
                    Response.Redirect("~/");
                }
                ViewState.Add("HoaDon", hoadon);
                txtMaHD.Text = hoadon.MaHopDong;
                txtNam.Text = Convert.ToString(hoadon.Nam);
                txtThang.Text = Convert.ToString(hoadon.Thang);
                txtTPhong.Text = Convert.ToString(hoadon.TienPhong);
                txtTDien.Text = Convert.ToString(hoadon.TienDien);
                txtTNuoc.Text = Convert.ToString(hoadon.TienNuoc);
                txtPhuPhi.Text = Convert.ToString(hoadon.PhuPhi);
                txtChiTiet.Text = hoadon.ChiTiet;
                chkDaThanhToan.Checked = hoadon.DaThanhToan;
                TinhTongTien();
            }
            else 
            {
                ReadData();
            }
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            ReadData();
            try
            {
                HoaDon hoadon = (HoaDon)ViewState["HoaDon"];
                hoadon.Update();
                TinhTongTien();
                alert = new Alert("success", "Thành công", String.Format("Hóa đơn \"{0}\" đã được cập nhật", hoadon.ID));
            }
            catch (SqlException exc)
            {
                alert = DB.ExceptionInfo(exc);
            }
        }

    }
}