using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace _20210327上課內容
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = Class1.showTotalDB();  //請輸入自己的DB相關函式
            ucPager.TotalSize = dt.Rows.Count;
            ucPager.Url = "~/WebForm1.aspx"; //請輸入自己的路徑
            ucPager.Bind();

            this.repList.DataSource = dt;
            this.repList.DataBind();
        }
    }
}