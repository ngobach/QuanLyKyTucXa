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
    public partial class TKHopDong : BasePage
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
                lblTong.Text = Convert.ToString(HopDong.TongSo());
                lblHH.Text = Convert.ToString(HopDong.SoHetHan());
                lblKetThuc.Text = Convert.ToString(HopDong.SoKetThuc());
            }
        }
    }
}