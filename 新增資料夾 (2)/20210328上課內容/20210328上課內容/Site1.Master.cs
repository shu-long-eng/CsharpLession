using _20210328上課內容.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210328上課內容
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        //private const string _sessionKey = "IsLogined";


        protected void Page_Load(object sender, EventArgs e)
        {
            if (LoginHelp.HasLogined())
            {
                this.Literal2.Text = LoginHelp.GetCurrentUserInfo();
                this.plc1.Visible = true;
                this.plc2.Visible = true;
            }
            else
            {
                this.plc1.Visible = false;
                this.plc2.Visible = false;
            }





            //bool? val = this.Session[_sessionKey] as bool?;
            //if (val.HasValue && val.Value)
            //{
            //    this.Literal2.Text = this.Session["Account"] as string;
            //    this.plc1.Visible = true;
            //    this.plc2.Visible = true;
            //}
            //else
            //{
            //    this.plc1.Visible = false;
            //    this.plc2.Visible = false;
            //}
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {

            if (LoginHelp.HasLogined())
            {
                this.Literal2.Text = LoginHelp.GetCurrentUserInfo();
                this.plc1.Visible = false;
                this.plc2.Visible = true;
                LoginHelp.Logout();
                Response.Redirect("~/WebForm5.aspx");
            }



            //bool? val = this.Session[_sessionKey] as bool?;
            //if (val.HasValue && val.Value)
            //{
            //    this.Session.Remove(_sessionKey);
            //    this.Session.Remove("Account");
            //    this.plc1.Visible = false;
            //    this.plc2.Visible = true;


        }
    }
 
}