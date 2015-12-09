using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace LapTrinhWeb
{
    public partial class MainTemplate : System.Web.UI.MasterPage
    {
        public bool HideNav = false;
        public bool InverseNavBar = false;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected string GetClass(String url)
        {
            return Request.Url.AbsolutePath.EndsWith(url)?"active":"";
        }
    }
}