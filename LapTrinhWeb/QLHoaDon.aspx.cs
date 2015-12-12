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
    public partial class QLHoaDon : BasePage
    {
        private void BindGrid()
        {
            if (ViewState["MaHD"] == null)
                Grid.DataSource = HoaDon.All();
            else
                Grid.DataSource = HoaDon.All((String)ViewState["MaHD"]);
            Grid.DataBind();
        }
        private void InitDrops()
        {
            dropMaHD.DataSource = HopDong.List();
            dropMaHD.DataTextField = "MaHopDong";
            dropMaHD.DataValueField = "MaHopDong";
            dropMaHD.DataBind();

            List<Int32> nam = new List<int>();
            for (int i = 2010; i <= 2020; i++)
                nam.Add(i);
            dropNam.DataSource = nam;
            dropNam.DataBind();

            List<Int32> thang = new List<int>();
            for (int i = 1; i <= 12; i++)
                thang.Add(i);
            dropThang.DataSource = thang;
            dropThang.DataBind();

            dropNam.SelectedValue = Convert.ToString(DateTime.Now.Year);
            dropThang.SelectedValue = Convert.ToString(DateTime.Now.Month);

            if (ViewState["MaHD"] != null)
            {
                dropMaHD.SelectedValue = (String)ViewState["MaHD"];
                dropMaHD.Enabled = false;
            }
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
                if (Request.QueryString["mahd"] != null)
                    ViewState.Add("MaHD", Request.QueryString["mahd"]);
                BindGrid();
                InitDrops();
            }
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hoadon = new HoaDon(dropMaHD.SelectedValue, Convert.ToInt32(dropNam.SelectedValue), Convert.ToInt32(dropThang.SelectedValue));
                hoadon.Insert();
                Response.BufferOutput = true;
                Response.Redirect("~/CTHoaDon.aspx?id=" + hoadon.ID);
            }
            catch (SqlException exc)
            {
                alert = DB.ExceptionInfo(exc);
            }
        }
        
        protected void Grid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Xoa"))
            {
                try {
                    HoaDon hoadon = HoaDon.Find(Convert.ToInt32(e.CommandArgument.ToString()));
                    if (hoadon != null)
                    {
                        hoadon.Delete();
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
            else if (e.CommandName.Equals("CapNhat"))
            {
                Response.BufferOutput = true;
                Response.Redirect("~/CTHoaDon.aspx?id="+e.CommandArgument.ToString());
            }
        }

        protected void Grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grid.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon WHERE Nam=@nam AND Thang=@thang AND MaHopDong=@mahd", DB.GetConnection());
            cmd.Parameters.AddWithValue("@nam", Convert.ToInt32(dropNam.SelectedValue));
            cmd.Parameters.AddWithValue("@thang", Convert.ToInt32(dropThang.SelectedValue));
            cmd.Parameters.AddWithValue("@mahd", dropMaHD.SelectedValue);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read() == false)
            {
                alert = new Alert("warning", "Lỗi", "Không tìm thấy hóa đơn phù hợp!");
            }
            else
            {
                SqlCommand sqlcmd = new SqlCommand("SELECT *,(TienPhong+TienDien+TienNuoc+PhuPhi) AS Tong FROM HoaDon WHERE Nam=@nam AND Thang=@thang AND MaHopDong=@mahd", DB.GetConnection());
                sqlcmd.Parameters.AddWithValue("@nam", Convert.ToInt32(dropNam.SelectedValue));
                sqlcmd.Parameters.AddWithValue("@thang", Convert.ToInt32(dropThang.SelectedValue));
                sqlcmd.Parameters.AddWithValue("@mahd", dropMaHD.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Grid.DataSource = dt;
                Grid.DataBind();
            }
        }
   
    }
}