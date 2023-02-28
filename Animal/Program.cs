using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Bob");
            Console.WriteLine(dog.Say());
            Console.ReadKey();
        }

    }
}
