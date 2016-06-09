using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LapTrinhWeb
{
    public partial class Header : System.Web.UI.UserControl
    {
        public bool HideNav = false;
        public bool InverseNavBar = false;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected string GetClass(String url)
        {
            return Request.Url.AbsoluteUri.EndsWith(url) ? "active" : "";
        }
    }
}