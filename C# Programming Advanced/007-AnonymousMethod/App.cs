using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_AnonymousMethod
{
    public class App
    {
        public delegate void  MessageDelegate(string message);
        public delegate int SquareDelegate(int x);
        public delegate int SumDelegate(int x, int y);
        public delegate void PrintDelegate();
        public void Run()
        {
            //anonymous method
            MessageDelegate messageDel = (msg) =>
            {
                Console.WriteLine(msg);
            };
            messageDel("Hello");

            SquareDelegate squareDel = x => x * x;
            Console.WriteLine(squareDel(100));

            SumDelegate sumDel = (xx,yy) => yy + xx;
            int result = sumDel(5, 10);
            Console.WriteLine("sum : {0}",result);

            PrintDelegate printDel = () => Console.WriteLine("Print");
            printDel();
        }

    }
}
