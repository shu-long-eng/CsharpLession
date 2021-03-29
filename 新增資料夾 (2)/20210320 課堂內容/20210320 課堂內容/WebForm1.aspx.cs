using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20210320_課堂內容
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[,] arr = { { "a1", "a1" }, { "b1", "b2" } };

            string outtext = string.Empty;

            for(int i = 0; i < 2; i++)
            {
                outtext += "<tr>";
                for(int j = 0; j < 2; j++)
                {
                    outtext += $@"
                                <td>{arr[i, j]}</td>
                                ";
                }
                outtext += "</tr>";
            }

            this.table.Text = outtext;



            //this.table.Text = @"<tr>
            //        <td>第一列</td>
            //        <td>第一列</td>
            //    </tr>
            //    <tr>
            //        <td>第二列</td>
            //        <td>第二列</td>
            //    </tr>";
        }
    }
}