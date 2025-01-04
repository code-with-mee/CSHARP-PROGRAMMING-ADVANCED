using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_List
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person() { }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine("Id : {0}, Name : {1}",Id,Name);
        }
    }
}
