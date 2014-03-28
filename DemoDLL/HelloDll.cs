using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDLL
{
    public class HelloDll
    {
        public static string GetDll()
        {
            return new HelloDll().GetPriDll();
        }

        private string GetPriDll()
        {
            return "hello dll";
        }
    }
}
