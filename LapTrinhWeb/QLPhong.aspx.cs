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
    public partial class QLPhong : BasePage
    {
        private void BindGrid()
        {
            Grid.DataSource = DBPhong.SelectAll();
            Grid.DataBind();
        }
        private bool ValidateForm()
        {
            if (txtName.Text.Length == 0)
            {
                alert = new Alert("danger", "Lỗi", "Tên phòng không được để trống!");
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
                BindGrid();
                ResetForm();
            }
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            try
            {
                DBPhong.Insert(txtName.Text);
                alert = new Alert("info", "Thành công", "Thêm phòng thành công");
                BindGrid();
            }catch (SqlException ex)
            {
                alert = DB.ExceptionInfo(ex);
            }
        }
        
        protected void Grid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Xoa"))
            {
                try {
                    DBPhong.Delete(Convert.ToInt32(e.CommandArgument.ToString()));
                    alert = new Alert("info", "Thành công", "Xóa thành công");
                    BindGrid();
                    ResetForm();
                }
                catch (SqlException exc)
                {
                    alert = DB.ExceptionInfo(exc);
                }
            }
            else if(e.CommandName.Equals("Sua"))
            {
                LoadForm((GridViewRow)((Control)e.CommandSource).NamingContainer,e.CommandArgument.ToString());
            }
        }

        protected void Grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grid.PageIndex = e.NewPageIndex;
            BindGrid();
        }


        private void LoadForm(GridViewRow row,String id)
        {
            btnAdd.Visible = false;
            btnSearch.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;

            ViewState.Add("ID", Convert.ToInt32(id));
            txtName.Text = DB.GetCellValue(row, "TenPhong");
        }

        private void ResetForm()
        {
            btnAdd.Visible = true;
            btnSearch.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;

            ViewState.Remove("ID");
            txtName.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;
            try {
                DBPhong.Update((int)ViewState["ID"], txtName.Text);
                alert = new Alert("success", "Thành công", "Phòng \"" + txtName.Text + "\" đã được cập nhật");
                ResetForm();
                BindGrid();
            }
            catch (SqlException ex)
            {
                alert = DB.ExceptionInfo(ex);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                alert = new Alert("warning", "Lỗi", "Chưa nhập nội dung tìm kiếm!");
                BindGrid();
                ResetForm();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Phong WHERE TenPhong=@ten", DB.GetConnection());
                cmd.Parameters.AddWithValue("@ten", txtName.Text);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read() == false)
                {
                    alert = new Alert("warning", "Lỗi", "Không tìm thấy phòng phù hợp!");
                }
                else
                {
                    SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Phong WHERE TenPhong=@ten", DB.GetConnection());
                    sqlcmd.Parameters.AddWithValue("@ten", txtName.Text);
                    SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Grid.DataSource = dt;
                    Grid.DataBind();
                }
            }
            
        }
        
    }
}