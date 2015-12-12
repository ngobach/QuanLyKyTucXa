using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LapTrinhWeb.App_Code;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace LapTrinhWeb
{
    public partial class QLSinhVien : BasePage
    {
        private void BindGrid()
        {
            Grid.DataSource = DBSinhVien.SelectAll();
            Grid.DataBind();
        }
        private bool ValidateForm()
        {
            DateTime tmp;
            if (txtMaSV.Text.Length < 10)
            {
                alert = new Alert("danger", "Lỗi", "Mã sinh viên gồm 10 kí tự");
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
            else if (txtLop.Text.Length == 0)
            {
                alert = new Alert("danger", "Lỗi", "Không được để trống lớp");
                return false;
            }
            else if (txtKhoa.Text.Length == 0)
            {
                alert = new Alert("danger", "Lỗi", "Không được để trống khoa");
                return false;
            }
            else if (radGioiTinh.SelectedValue == null)
            {
                alert = new Alert("danger", "Lỗi", "Không được để trống giới tính");
                return false;
            }else if (!Regex.IsMatch(txtSDT.Text,@"^\d*$")){
                alert = new Alert("danger", "Lỗi", "Số điện thoại không hợp lệ!");
                return false;
            }
            return true;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            btnShowAll.Visible = false;
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
                DBSinhVien.Insert(txtMaSV.Text, txtFullName.Text, txtSDT.Text, DateTime.Parse(txtNgaySinh.Text), radGioiTinh.SelectedValue, txtQueQuan.Text, txtLop.Text, txtKhoa.Text);
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
                    DBSinhVien.Delete(e.CommandArgument.ToString());
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

            ViewState.Add("MaSV", username);
            txtMaSV.Text = DB.GetCellValue(row, "MaSV");
            txtFullName.Text = DB.GetCellValue(row, "HoTen");
            txtSDT.Text = DB.GetCellValue(row, "SoDienThoai");
            txtNgaySinh.Text = DB.GetCellValue(row, "NgaySinh");
            radGioiTinh.SelectedValue = DB.GetCellValue(row, "GioiTinh");
            txtQueQuan.Text = DB.GetCellValue(row, "QueQuan");
            txtLop.Text = DB.GetCellValue(row, "Lop");
            txtKhoa.Text = DB.GetCellValue(row, "Khoa");
        }

        private void ResetForm()
        {
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;

            ViewState.Remove("ID");
            txtMaSV.Text = "";
            txtFullName.Text = "";
            txtSDT.Text = "";
            txtNgaySinh.Text = "";
            radGioiTinh.SelectedValue = "";
            txtQueQuan.Text = "";
            txtLop.Text = "";
            txtKhoa.Text = "";
            txtSearch.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;
            try {
                DateTime date = DateTime.Parse(txtNgaySinh.Text);
                DBSinhVien.Update(ViewState["MaSV"].ToString(), txtMaSV.Text, txtFullName.Text, txtSDT.Text, DateTime.Parse(txtNgaySinh.Text), radGioiTinh.SelectedValue, txtQueQuan.Text, txtLop.Text, txtKhoa.Text);
                alert = new Alert("success", "Thành công", "Sinh viên \"" + txtMaSV.Text + "\" đã được cập nhật");
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
            if (txtSearch.Text == "")
            {
                alert = new Alert("Eror", "Lỗi", "Chưa nhập mã sinh viên");
                BindGrid();
                ResetForm();
            }
            else 
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien WHERE MaSV=@masv",DB.GetConnection());
                cmd.Parameters.AddWithValue("@masv", txtSearch.Text);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read() == false)
                {
                    alert = new Alert("EROR", "Lỗi", "Mã sinh viên vừa nhập không tồn tại");
                    Grid.Visible = false;
                    ResetForm();
                    btnShowAll.Visible = true;
                }
                else
                {
                    SqlCommand sqlcmd = new SqlCommand("SELECT * FROM SinhVien WHERE MaSV=@masv", DB.GetConnection());
                    sqlcmd.Parameters.AddWithValue("masv", txtSearch.Text);
                    SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataView dv = new DataView(dt);
                    Grid.DataSource = dv;
                    Grid.DataBind();
                    ResetForm();
                    btnShowAll.Visible = true;
                }
            }
        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            BindGrid();
            Grid.Visible = true;
            btnShowAll.Visible = false;
        }
        
    }
}