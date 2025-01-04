using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_DelegateMulticast
{
    public delegate void CalculatorDelegate(float  x,float y);
    public class App
    {
        public void Run()
        {
            //delegate multicast
            Calculator calculator = new Calculator();
            CalculatorDelegate calDel = calculator.Sum;
            calDel += calculator.Sub;
            calDel += calculator.Mul;
            calDel += calculator.Div;

            calDel -= calculator.Div;

            calDel(200, 100);
        }
    }
}
