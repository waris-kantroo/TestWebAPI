using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebAPI
{
    public static class TryStatic
    {

        public static void TrystaticMethod()
        {

        }

        public  static void TrystaticMethod2()  // can't have non static methods inside static class because by definition it can't be instantiated so there's no possibility to use these members
        {

        }
    }
}