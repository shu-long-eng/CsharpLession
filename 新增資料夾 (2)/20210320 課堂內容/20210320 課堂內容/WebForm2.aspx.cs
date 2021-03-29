using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace _20210320_課堂內容
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = Class1.searchDB();
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
}