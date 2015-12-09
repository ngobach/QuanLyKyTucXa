using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using LapTrinhWeb.App_Code;

namespace LapTrinhWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected Alert alert = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Master.HideNav = true;
        }

        protected void DoLogin(object sender, EventArgs e)
        {
            String username = Username.Text, password = Password.Text;
            if (!DBUser.IsValid(username,password))
            {
                alert = new Alert("warning","Đăng nhập sai", "Thông tin đăng nhập chưa chính xác!");
            }
            else
            {
                Response.BufferOutput = true;
                alert = new Alert("success", "Thành công", "Đăng nhập thành công!");
                Session["Username"] = username;
                Response.Redirect("/Default.aspx");
            }
        }
    }
}