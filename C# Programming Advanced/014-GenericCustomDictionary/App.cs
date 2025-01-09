using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_GenericCustomDictionary
{
    public class App
    {
        public void Run()
        {
            //generic custom dictionary
            MyDictionary<string,string> fullNames = new MyDictionary<string,string>();
            fullNames.Add("sok", "raksa");
            fullNames.Add("chant", "both");
            fullNames.Add("mak", "nisa");

            string value = fullNames["sok"];
            Console.WriteLine("lastname : {0}",value);

            foreach (var element in fullNames)
            {
                Console.WriteLine(element.Key + " | " + element.Value);
            }
               
        }
    }
}
