using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overload
{
    internal class Methods
    {
        public static int Add (int a, int b) 
        {
            return a + b;        
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool istrue)
        {
            if (a + b > 1 && istrue)
            {
              return $"{a + b} Dollars ";
            }
            else
            {
                return $"{a + b} Dollar";
            }
            
        }



    }
}
