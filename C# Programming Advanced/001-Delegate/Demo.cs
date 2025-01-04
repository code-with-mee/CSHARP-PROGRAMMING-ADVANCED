using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Delegate
{
    public delegate void MessageDelegate();
    public delegate void SumDelegate(int x,int y);
    public delegate float MulDelegate(float x,float y);
    public class Demo
    {
        public void Run()
        {
            //demo delegate
            //what is delegate?
            MessageDelegate messageDel = Message;
            //messageDel();
            messageDel.Invoke();

            SumDelegate sumDel = SumNumber;
            sumDel(10, 20);

            MulDelegate mulDel = MulNumber;
            float resultMul = mulDel(10, 20);
            Console.WriteLine("Mul : {0}",resultMul);
        }

        private float MulNumber(float x,float y)
        {
            return x * y;
        }
        private void SumNumber(int x,int y)
        {
            Console.WriteLine("Sum : {0}", x + y);
        }
        private void Message()
        {
            Console.WriteLine("Hello world");
        }
    }
}
