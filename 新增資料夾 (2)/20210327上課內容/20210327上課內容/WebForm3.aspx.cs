using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210327上課內容
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("WebForm3.Page_PreInit <br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("WebForm3.Page_Init <br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("WebForm3.Page_Load <br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("WebForm3.Page_PreRender <br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("WebForm3.Button_click <br/>");
        }
    }
}