using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210320_課堂內容
{
    public partial class repeater : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            DataTable dt = Class1.searchDB();
            this.Repeater1.DataSource = dt;
            this.Repeater1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Repeater1_DataBinding(object sender, EventArgs e)
        {

        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType == ListItemType.Item||
                e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Literal ltl = e.Item.FindControl("ltName") as Literal;

                if (ltl == null) return;

                DataRowView drv = e.Item.DataItem as DataRowView;

                int? id = drv.Row.Field<int?>("ID");




                if(id.HasValue && id.Value == 1)
                ltl.Text = "Success!!";
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string cmdName = e.CommandName;

            string cmdArgu = e.CommandArgument.ToString();

            if ("deleteItem" == cmdName)
            {
                Class1.deleteDB(cmdArgu);

                DataTable dt = Class1.searchDB();
                this.Repeater1.DataSource = dt;
                this.Repeater1.DataBind();

            }
        }
    }
}