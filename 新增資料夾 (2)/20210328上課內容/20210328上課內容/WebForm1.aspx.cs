using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210328上課內容
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gsVal = this.Request.QueryString["page"];
            string postVa = this.Request.Form["Account"];
            string accept = this.Request.Headers["Accept-Language"];

            Uri reqUri = this.Request.Url;
            string rawUrl = this.Request.RawUrl; //現在網頁的網址
            string referrer = this.Request.UrlReferrer?.ToString(); //前一頁的網址

            Response.Write(rawUrl + "<br />");
            Response.Write(referrer + "<br />");
           // Response.Write(accept + "<br />");

            this.ListAllContent(this.Request.QueryString);
            //this.ListAllContent(this.Request.Form);

            //this.ListAllContent(this.Request.Headers);


        }
        private void ListAllContent (NameValueCollection collection)
        {
            foreach(var key in collection.AllKeys)
            {
                var value = collection[key];
                Response.Write($"Key:{key},value:{value}<br />");
            }
        }
        public static void GotoErrorPage(string msg)
        {
            HttpContext.Current.Response.StatusCode = 402;

            HttpContext.Current.Response.Write(msg);

            HttpContext.Current.Response.Flush();

            HttpContext.Current.Response.SuppressContent = true;

            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GotoErrorPage("123");
        }
    }
}