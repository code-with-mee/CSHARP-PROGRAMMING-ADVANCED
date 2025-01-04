using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_List
{
    public class App
    {
        public void Run()
        {
            //list
            List<string> names = new List<string>();
            names.Add("Pisey");
            names.Add("both");
            names.Add("raksa");

            //names.Remove("Pisey");
            //names.RemoveAt(0);
            //names.Clear();

            if(names.Contains("raksa"))
                Console.WriteLine("list contain name raksa");

            foreach (string name in names)
                Console.WriteLine("name : {0}",name);

            Console.WriteLine("================");

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(30);
            numbers.Add(45);
            foreach(int number in numbers)
                Console.WriteLine("number : {0}",number);

            Console.WriteLine("===================");

            List<Person> persons = new List<Person>();
            persons.Add(new Person(1,"roth"));
            persons.Add(new Person(2,"chetra"));
            foreach (Person person in persons)
                person.Display();

            List<List<Person>> list = new List<List<Person>>();
        }
    }
}
