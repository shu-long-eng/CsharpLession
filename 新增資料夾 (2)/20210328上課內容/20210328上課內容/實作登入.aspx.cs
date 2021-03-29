using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210328上課內容
{
    public partial class 實作登入 : System.Web.UI.Page
    {
        private const string _sessionKey = "IsLogined";

        private string _gotToUrl = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            _gotToUrl = Request.RawUrl;
            bool? val = this.Session[_sessionKey] as bool?;
            if(val.HasValue && val.Value)
            {
                this.Literal2.Text = this.Session["Account"] as string;
                this.plc1.Visible = false;
                this.plc2.Visible = true;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool isAccountRight = string.Compare("admin", this.txtAccount.Text.Trim(), true) == 0;
            bool isPasswordRight = string.Compare("123456", this.txtPassword.Text.Trim()) == 0;

            if(isAccountRight && isPasswordRight)
            {
                this.Session["Account"] = this.txtAccount.Text;
                this.Session[_sessionKey] = true;
                this.Literal1.Text = "Success";
                this.plc1.Visible = false;
                this.plc2.Visible = true;
                Response.Redirect(this._gotToUrl);
            }
            else
            {
                this.Literal1.Text = "Fail";
                this.plc1.Visible = true;
                this.plc2.Visible = false;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            bool? val = this.Session[_sessionKey] as bool?;
            if (val.HasValue && val.Value)
            {
                this.Session.Remove(_sessionKey);
                this.Session.Remove("Account");

                
                this.plc1.Visible = false;
                this.plc2.Visible = true;

                Response.Redirect(this._gotToUrl);
            }
        }
    }
}