using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210328上課內容
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        private const string _sessionKey = "IsLogined";

        private string _gotToUrl = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            _gotToUrl = Request.RawUrl;
            bool? val = this.Session[_sessionKey] as bool?;
            if (val.HasValue && val.Value)
            {
                this.Literal1.Text = this.Session["Account"] as string;
            }
        }
    }
}