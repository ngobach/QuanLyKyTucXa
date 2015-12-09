using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LapTrinhWeb.App_Code;
using System.Data.SqlClient;
using System.Data;


namespace LapTrinhWeb
{
    public partial class QLUser : BasePage
    {
        private void BindGrid()
        {
            Grid.DataSource = DBUser.SelectAll();
            Grid.DataBind();
        }
        private bool ValidateForm()
        {
            DateTime tmp;
            if (txtUsername.Text.Length < 4)
            {
                alert = new Alert("danger", "Lỗi", "Username tối thiểu 4 kí tự");
                return false;
            }
            else if (txtPassword.Text.Length>0 &&  txtPassword.Text.Length < 6)
            {
                alert = new Alert("danger", "Lỗi", "Mật khẩu tối thiểu 6 kí tự");
                return false;
            }
            else if (txtPassword.Text.Length>0 && txtPassword.Text != txtRePassword.Text)
            {
                alert = new Alert("danger", "Lỗi", "Mật khẩu nhập lại không khớp");
                return false;
            }
            else if (txtFullName.Text.Length == 0)
            {
                alert = new Alert("danger", "Lỗi", "Không được để trống họ tên");
                return false;
            }
            else if (txtQueQuan.Text.Length == 0)
            {
                alert = new Alert("danger", "Lỗi", "Không được để trống quê quán");
                return false;
            }
            else if (!DateTime.TryParse(txtNgaySinh.Text,out tmp))
            {
                alert = new Alert("danger", "Lỗi", "Ngày sinh không hợp lệ");
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
                DBUser.Insert(txtUsername.Text, txtPassword.Text, txtFullName.Text, DateTime.Parse(txtNgaySinh.Text), txtQueQuan.Text);
                alert = new Alert("info", "Thành công", "Thêm user thành công");
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
                    DBUser.Delete(e.CommandArgument.ToString());
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


        private void LoadForm(GridViewRow row,String username)
        {
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;

            ViewState.Add("Username", username);
            txtUsername.Text = DB.GetCellValue(row, "Username");
            txtFullName.Text = DB.GetCellValue(row, "HoTen");
            txtNgaySinh.Text = DB.GetCellValue(row, "NgaySinh");
            txtQueQuan.Text = DB.GetCellValue(row, "QueQuan");
            txtUsername.ReadOnly = true;
        }

        private void ResetForm()
        {
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;

            ViewState.Remove("ID");
            txtUsername.Text = "";
            txtFullName.Text = "";
            txtNgaySinh.Text = "";
            txtQueQuan.Text = "";
            txtUsername.ReadOnly = false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;
            try {
                DateTime date = DateTime.Parse(txtNgaySinh.Text);
                DBUser.Update(ViewState["Username"].ToString(), txtPassword.Text, txtFullName.Text, date, txtQueQuan.Text);
                alert = new Alert("success", "Thành công", "User \"" + txtUsername.Text + "\" đã được cập nhật");
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
        
    }
}