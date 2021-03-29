using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20210328上課內容
{
    public class itemsClass
    {
        public static string GetItemValue()
        {
            return HttpContext.Current.Items["key1"] as string;
        }
    }
}