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
using System.Diagnostics;

namespace LapTrinhWeb
{
    public partial class TKHoaDon : BasePage
    {
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
                int tong = HoaDon.TongSo();
                int chuatt = HoaDon.ChuaTT();
                lblTong.Text = Convert.ToString(tong);
                lblChuaTT.Text = Convert.ToString(chuatt);
                lblDaTT.Text = Convert.ToString(tong-chuatt);
                BindTong();
            }
        }
        private void BindTong()
        {
            SqlCommand cmd = new SqlCommand("SELECT HopDong.*, HoaDon.*, (TienPhong+TienDien+TienNuoc+PhuPhi) AS Tong FROM HoaDon,HopDong WHERE HoaDon.MaHopDong = Hopdong.MaHopDong", DB.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            Grid.DataBind();
        }

        private void BindChuatt()
        {
            SqlCommand cmd = new SqlCommand("SELECT HopDong.*, HoaDon.*, (TienPhong+TienDien+TienNuoc+PhuPhi) AS Tong FROM HoaDon,HopDong WHERE HoaDon.MaHopDong = Hopdong.MaHopDong AND DaThanhToan='False'", DB.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            Grid.DataBind();
        }

        private void BindDaTT()
        {
            SqlCommand cmd = new SqlCommand("SELECT HopDong.*, HoaDon.*,(TienPhong+TienDien+TienNuoc+PhuPhi) AS Tong FROM HoaDon,HopDong WHERE HoaDon.MaHopDong = Hopdong.MaHopDong AND DaThanhToan='True'", DB.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            Grid.DataBind();
        }

        protected void btnTong_Click(object sender, EventArgs e)
        {
            ViewState["Mode"] = null;
            BindTong();
        }



        protected void Grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grid.PageIndex = e.NewPageIndex;
            if ((String)ViewState["Mode"] == "ChuaTT")
                BindChuatt();
            else if ((String)ViewState["Mode"] == "DaTT")
                BindDaTT();
            else
                BindTong();
        }

        protected void btnChuaTT_Click(object sender, EventArgs e)
        {
            ViewState["Mode"] = "ChuaTT";
            BindChuatt();
        }

        protected void btnDaTT_Click(object sender, EventArgs e)
        {
            ViewState["Mode"] = "DaTT";
            BindDaTT();
        }
    }
}