using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_DelegateMulticast
{
    public class Calculator
    {
        public void Sum(float x,float y)
        {
            Console.WriteLine("Sum : {0}",x+y);
        }
        public void Sub(float x, float y)
        {
            Console.WriteLine("Sum : {0}", x - y);
        }
        public void Mul(float x, float y)
        {
            Console.WriteLine("Sum : {0}", x * y);
        }
        public void Div(float x, float y)
        {
            Console.WriteLine("Sum : {0}", x / y);
        }
    }
}
