using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class
{
    class Animal
    {
        string name = "Audi";
        int age = 6;
        
        public void printDetails()
        {
            Console.WriteLine("Name " + name + " " + "Age " + age);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.printDetails();
        }
    }
}
