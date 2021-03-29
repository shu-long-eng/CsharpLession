using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210327上課內容
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("主板_PreInit <br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("主板_Init <br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("主板_Load <br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("主板_PreRender <br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("主板_button <br/>");
        }
    }
}