using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace LapTrinhWeb.App_Code
{
    public class DB
    {
        public const int ERR_KEYCONFLICT = 2627;
        private static SqlConnection _conn;
        public static SqlConnection GetConnection()
        {
            String str = WebConfigurationManager.ConnectionStrings["Main"].ConnectionString;
            if (_conn == null || _conn.State == System.Data.ConnectionState.Closed)
            {
                _conn = new SqlConnection(str);
                _conn.Open();
            }
            return _conn;
        }

        public static Alert ExceptionInfo(SqlException exc)
        {
            switch (exc.Number)
            {
                case ERR_KEYCONFLICT:
                    return new Alert("danger", "Lỗi dữ liệu", "Khóa chính bị trùng!");
                default:
                    return new Alert("warning", "Lỗi SQL " + exc.Number, exc.Message);
            }
        }

        public static int GetColumnIndexByName(GridViewRow row, string columnName)
        {
            int columnIndex = 0;
            foreach (DataControlFieldCell cell in row.Cells)
            {
                if (cell.ContainingField is BoundField)
                    if (((BoundField)cell.ContainingField).DataField.Equals(columnName))
                        break;
                columnIndex++;
            }
            return columnIndex;
        }

        public static String GetCellValue(GridViewRow r,String col)
        {
            foreach (DataControlFieldCell cell in r.Cells)
            {
                if (cell.ContainingField is BoundField)
                    if (((BoundField)cell.ContainingField).DataField.Equals(col))
                        return HttpUtility.HtmlDecode(cell.Text);
            }
            return "";
        }
    }
}