using _20210328上課內容.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210328上課內容
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        private const string _sessionKey = "IsLogined";
       // private string _gotToUrl = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (LoginHelp.HasLogined())
            { this.Literal1.Text = LoginHelp.GetCurrentUserInfo(); }
                
            






            //_gotToUrl = Request.RawUrl;
            //bool? val = this.Session[_sessionKey] as bool?;
            //if (val.HasValue && val.Value)
            //{
            //    this.Literal1.Text = this.Session["Account"] as string;
            //    this.plc1.Visible = false;

            //}
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string acc = this.txtAccount.Text;
            string pw = this.txtPassword.Text;
            bool isSuccess = LoginHelp.TryLogin(acc, pw);


            if (isSuccess)
            {
                this.Literal1.Text = "Success";
                this.plc1.Visible = false;
                //this.plc2.visible = true;
                Response.Redirect("~/WebForm4.aspx");
            }
            else
            {
                this.Literal1.Text = "Fail";
                this.plc1.Visible = true;
            }




            //bool isAccountRight = string.Compare("admin", this.txtAccount.Text.Trim(), true) == 0;
            //bool isPasswordRight = string.Compare("123456", this.txtPassword.Text.Trim()) == 0;

            //if (isAccountRight && isPasswordRight)
            //{
            //    this.Session["Account"] = this.txtAccount.Text;
            //    this.Session[_sessionKey] = true;
            //    this.Literal1.Text = "Success";
            //    this.plc1.Visible = false;
            //    Response.Redirect("~/WebForm4.aspx");
            //}
            //else
            //{
            //    this.Literal1.Text = "Fail";
            //    this.plc1.Visible = true;
            //}
        }
    }
}