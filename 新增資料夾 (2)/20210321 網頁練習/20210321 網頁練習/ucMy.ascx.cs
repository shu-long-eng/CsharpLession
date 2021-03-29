using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210321_網頁練習
{
    public partial class uc : System.Web.UI.UserControl
    {
        public string ucName{get;set;}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack) return;


            this.Literal1.Text = "Hellow"+ucName;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Literal1.Text = "--";
        }
    }
}