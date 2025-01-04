using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_GenericMethod
{
    public class App
    {
        public void Run()
        {
            //generic method
            string a = "Hello";
            string b = "hi";
            Util.Swap(ref a,ref b);

            Console.WriteLine("a : {0}",a);
            int num1 = 100;
            int num2 = 200;

            Util.Swap<int>(ref num1, ref num2);
            Console.WriteLine("number : {0}",num1);

            Person p1 = new Person(1,"both");
            Person p2 = new Person(2,"vichet");
            Util.Swap<Person>(ref p1, ref p2);
            p1.Display();
        }
    }
}
