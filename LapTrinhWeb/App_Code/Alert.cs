using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LapTrinhWeb.App_Code
{
    public class Alert
    {
        public String Class;
        public String Title;
        public String Content;
        public Alert(String clss,String tit,String cont)
        {
            Class = clss;
            Title = tit;
            Content = cont;
        }

    }
}