using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210328上課內容
{
    public partial class cookie練習 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = new HttpCookie("test");
                cookie.Value = Server.UrlEncode("Hellow");
                cookie.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(cookie);
            }
        }
    }
}