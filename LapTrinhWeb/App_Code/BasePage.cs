using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LapTrinhWeb.App_Code;
using System.Data.SqlClient;
using System.Data;

namespace LapTrinhWeb.App_Code
{
    public class BasePage : System.Web.UI.Page
    {
        protected Alert alert;
        protected RowSelectHandler selectHandler;
        protected void SetTargetGrid(GridView gv)
        {
            selectHandler = new RowSelectHandler(gv);
        }
    }
}