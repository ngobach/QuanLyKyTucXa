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
    public partial class QLHopDong : BasePage
    {
        private void BindGrid()
        {
            Grid.DataSource = HopDong.All();
            Grid.DataBind();
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
                BindGrid();
            }
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.BufferOutput = true;
            Response.Redirect("~/CTHopDong.aspx");
        }
        
        protected void Grid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Xoa"))
            {
                try {
                    HopDong hopdong = HopDong.Find(e.CommandArgument.ToString());
                    if (hopdong != null)
                    {
                        hopdong.Delete();
                        alert = new Alert("info", "Thành công", "Xóa thành công");
                    }
                    else
                    {
                        alert = new Alert("warning", "Thất bại", "Hợp đồng không tồn tại");
                    }
                    BindGrid();
                }
                catch (SqlException exc)
                {
                    alert = DB.ExceptionInfo(exc);
                }
            }
            else if(e.CommandName.Equals("CapNhat"))
            {
                Response.BufferOutput = true;
                Response.Redirect("~/CTHopDong.aspx?id="+e.CommandArgument.ToString());
            }
        }

        protected void Grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grid.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        
    }
}