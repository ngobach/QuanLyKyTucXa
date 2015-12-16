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
                int tong = HopDong.TongSo();
                int ketthuc = HopDong.SoKetThuc();
                lblTong.Text = Convert.ToString(tong);
                lblChuaKT.Text = Convert.ToString(tong - ketthuc);
                lblKetThuc.Text = Convert.ToString(ketthuc);
                BindTong();
            }
        }

        protected void Grid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("HoaDon"))
            {
                Response.BufferOutput = true;
                Response.Redirect("~/QLHoaDon.aspx?mahd=" + e.CommandArgument.ToString());
            }
        }

        private void BindTong()
        {
            Grid.DataSource = HopDong.All();
            Grid.DataBind();
        }

        private void BindChuakt()
        {
            Grid.DataSource = HopDong.Chuakt();
            Grid.DataBind();
        }

        private void BindDakt()
        {
            Grid.DataSource = HopDong.Dakt();
            Grid.DataBind();
        }

        protected void btnTong_Click(object sender, EventArgs e)
        {
            ViewState["Mode"] = null;
            BindTong();
        }

        protected void btnChuakt_Click(object sender, EventArgs e)
        {
            ViewState["Mode"] = "Chuakt";
            BindChuakt();
        }

        protected void btnDakt_Click(object sender, EventArgs e)
        {
            ViewState["Mode"] = "Dakt";
            BindDakt();
        }

        protected void Grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grid.PageIndex = e.NewPageIndex;
            if ((String)ViewState["Mode"] == "ChuaTT")
                BindChuakt();
            else if ((String)ViewState["Mode"] == "DaTT")
                BindDakt();
            else
                BindTong();
        }
    }
}