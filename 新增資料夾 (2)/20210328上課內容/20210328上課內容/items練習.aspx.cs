using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210328上課內容
{
    public partial class items練習 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Response.Write(Items["key1"] + "<br />");
            
            Response.Write(itemsClass.GetItemValue() + "<br />");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Items["key1"] = "hellow";
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
           // Response.Write(Items["key1"] + "<br />");

           Response.Write(itemsClass.GetItemValue() + "<br />");
        }
    }
}