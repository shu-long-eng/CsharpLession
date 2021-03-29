using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210327_課堂作業
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_load(object sender, EventArgs e)
        {

            
            this.PlaceHolder1.Controls.Add(new TextBox());

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Control control = this.PlaceHolder1.Controls[0];
            TextBox text = control as TextBox;

            Response.Write(text.Text);
        }
    }
}