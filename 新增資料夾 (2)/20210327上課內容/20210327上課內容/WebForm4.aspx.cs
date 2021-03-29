using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210327上課內容
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            this.PlaceHolder1.Controls.Add(
                new Button()
                {
                    Text = "Hellow"
                }
                );
            WebUserControl2 ctl = (WebUserControl2)Page.LoadControl("~/WebUserControl2.ascx");
            this.PlaceHolder1.Controls.Add(ctl);
        }
    }
}