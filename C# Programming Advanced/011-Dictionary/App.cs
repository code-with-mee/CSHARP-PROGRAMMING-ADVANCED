using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Dictionary
{
    public class App
    {
        public void Run()
        {
            //dictionary
            Dictionary<string,int> mydictionary = new Dictionary<string,int>();
            mydictionary.Add("one", 1);
            mydictionary.Add("two", 2);
            mydictionary.Add("three", 3);

            //mydictionary.Remove("two");
            Console.WriteLine(mydictionary["one"]);

            if(mydictionary.ContainsKey("two"))
                Console.WriteLine(mydictionary["two"]);


            foreach(var element in mydictionary)
            {
                Console.WriteLine(element.Key + " | " + element.Value);
            }

            Console.WriteLine("===================");

            Dictionary<string,Student> students = new Dictionary<string,Student>();
            students.Add("piset", new Student(1, "pist"));
            students.Add("vichet", new Student(2, "vichet"));
            students.Add("nita", new Student(3, "nita"));

            foreach (var element in students)
                element.Value.Display();

            List<Student> list = new List<Student>();
            list.Add(new Student(1, "pist"));
            list.Add(new Student(2, "vichet"));
            list.Add(new Student(3, "nita"));

            Dictionary<string,List<Student>> studentLists = new Dictionary<string,List<Student>>();
            studentLists.Add("Google", list);
            foreach(var element in studentLists)
            {
                Console.WriteLine("Room : {0}",element.Key);
                foreach (var student in element.Value)
                    student.Display();
            }
        
        }
    }
}
