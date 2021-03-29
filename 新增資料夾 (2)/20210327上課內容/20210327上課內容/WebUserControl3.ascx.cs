using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210327上課內容
{
    public partial class WebUserControl3 : System.Web.UI.UserControl
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("UC-3_PreInit <br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("UC-3_Page_Init <br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("UC-3_Page_Load <br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("UC-3_Page_PreRender <br/>");
        }
    }
}