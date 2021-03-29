using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210321_課堂練習_物件導向
{
    class Class2 : Class1
    {
        public int property2 { get; set; }
    }

    public class maru
    {
        public double get(double n)
        {
            double result = Math.Pow(n, 2) * Math.PI;

            return result;
        }
    }


}
