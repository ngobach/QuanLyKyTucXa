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
            }
        }
        private void BindTong()
        {
            if (ViewState["MaHD"] == null)
                Grid.DataSource = HoaDon.All();
            else
                Grid.DataSource = HoaDon.All((String)ViewState["MaHD"]);
            Grid.DataBind();
        }

        private void BindChuatt()
        {
            SqlCommand cmd = new SqlCommand("SELECT *,(TienPhong+TienDien+TienNuoc+PhuPhi) AS Tong FROM HoaDon WHERE DaThanhToan='False'", DB.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
            Grid.DataBind();
        }

        protected void btnTong_Click(object sender, EventArgs e)
        {
            //Response.Redirect("QLHoadon.aspx");
            
            BindTong();
            Response.Redirect("TKHoaDon.aspx?dk=all");
        }



        protected void Grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grid.PageIndex = e.NewPageIndex;
            BindChuatt();
        }

        protected void btnChuaTT_Click(object sender, EventArgs e)
        {
            Response.Redirect("TKHoaDon.aspx?dk=chuatt");
            BindChuatt();
        }
    }
}