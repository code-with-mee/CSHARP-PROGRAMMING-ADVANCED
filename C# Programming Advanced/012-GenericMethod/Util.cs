using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _012_GenericMethod
{
    public class Util
    {
        public static void Swap(ref string a,ref string b)
        {
            string c = a;
            a = b;
            b = c;
        }

        public static void Swap<T>(ref T a,ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }
}
