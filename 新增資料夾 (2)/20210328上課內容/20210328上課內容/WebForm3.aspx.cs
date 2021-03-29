using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210328上課內容
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int? val = Application["key"] as int?;

            int? val1 = Session["key1"] as int?;

            this.Literal1.Text = val.Value.ToString() + val1.Value.ToString();
        }
    }
}