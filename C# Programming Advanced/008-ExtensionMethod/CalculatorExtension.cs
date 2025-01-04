using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_ExtensionMethod
{
    public static class CalculatorExtension
    {
        public static float Mul(this Calculator cal,
            float x,float y)
        {
            return x * y;
        }

        public static  float Div(this Calculator cal,
            float x,float y)
        { 
            return x / y; 
        }
    }
}
