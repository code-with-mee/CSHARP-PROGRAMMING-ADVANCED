using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _011_Dictionary
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student() { }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine("Id : {0}, Name : {1}", Id, Name);
        }
    }
}
