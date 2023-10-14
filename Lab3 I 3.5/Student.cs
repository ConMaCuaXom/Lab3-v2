using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_I_3._5
{
    public class Student
    {
        public int Id;
        public string Name = "";
        public int Age;

        public void Display()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " +  Name);
            Console.WriteLine("Age: " +  Age);
        }
    }
}
