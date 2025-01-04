using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_ExtensionMethod
{
    public class App
    {
        public void Run()
        {
            //extension method
            Calculator calculator = new Calculator();
            calculator.Sum(10, 20);
            calculator.Sub(20, 30);
            calculator.Mul(20, 30);
            calculator.Div(20, 30);
        }
    }
}
