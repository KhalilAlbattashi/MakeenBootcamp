using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    /*
     to make an extension you need a static class in the same name space and inside the class a public static
     method to use the extension elsewhere.
     */
    static class Extension
    {
        //global extension for the int class
        public static int mirror(this int x)
        {
            char[] y = x.ToString().ToCharArray();

            Array.Reverse(y);
            
            return int.Parse(new string(y));  
        }
    }
}
