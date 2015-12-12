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

        protected void btnTong_Click(object sender, EventArgs e)
        {
            Response.Redirect("QLHoadon.aspx");
        }
    }
}