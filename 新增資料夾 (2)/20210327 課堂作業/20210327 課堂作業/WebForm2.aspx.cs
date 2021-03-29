using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210327_課堂作業
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public class TempData
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<TempData> list = new List<TempData>();
            list.Add(new TempData() { ID = 1, Name = "AAA" });
            list.Add(new TempData() { ID = 2, Name = "BBB" });

            this.Repeater1.DataSource = list;
            this.Repeater1.DataBind();
        }

        
protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            TempData sourceData = e.Item.DataItem as TempData;
            var ltl = e.Item.FindControl("Literal1") as Literal;
            ltl.Text = sourceData.Name;
        }
    }
}