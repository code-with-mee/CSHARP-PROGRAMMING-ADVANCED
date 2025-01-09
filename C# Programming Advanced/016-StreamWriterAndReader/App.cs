using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace _016_StreamWriterAndReader
{
    public class App
    {
        public void Run()
        {
            Write();
            //Read();
            ReadByLine();
        }

        private void Write()
        {
            StreamWriter writer = new StreamWriter("data.txt");
            writer.WriteLine("Hello");
            writer.WriteLine("HI");
            writer.WriteLine("Welcome");
            writer.Close();
        }

        private void Read()
        {
            StreamReader reader = new StreamReader("data.txt");
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
            reader.Close();
        }

        private void ReadByLine()
        {
            StreamReader reader = new StreamReader("data.txt");
            string line;
            while((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
