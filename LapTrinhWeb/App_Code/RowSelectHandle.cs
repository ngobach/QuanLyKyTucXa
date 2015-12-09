using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LapTrinhWeb.App_Code;
using System.Data.SqlClient;

namespace LapTrinhWeb.App_Code
{
    public class RowSelectHandler
    {
        private GridView grid;
        public RowSelectHandler(GridView grid)
        {
            this.grid = grid;
        }

        public void SelectRow(int i)
        {
            if (grid.SelectedRow != null)
                grid.SelectedRow.CssClass = "";
            grid.SelectedIndex = i;
            if (grid.SelectedIndex >= 0)
                grid.SelectedRow.CssClass = "info";
        }
    }
}