using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210327上課內容
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Site1 masterPage = (this.Master as Site1);
            masterPage.SType =  Site1.SourceType.Inner;
            //masterPage.HeaderText = "GOOD";
            masterPage.SetHeaderText("2222222");
        }
    }
}