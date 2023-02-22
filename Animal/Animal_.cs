using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Animal_
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        { Name = name; }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    class Cat : Animal
    {
        //private string say;
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;

        }
        public Cat (string name)//, string say)
            : base(name)
        // { this.say = say; }
        public override void Say()
        {
            //Console.WriteLine(say);
            Console.WriteLine("Miau");
        }

    }
    class Dog : Animal
    {
        //private string say;
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;

        }
        public Cat(string name)//, string say)
            : base(name)
       // { this.say = say; }
        public override void Say()
        {
            //Console.WriteLine(say);
            Console.WriteLine("Woof");
        }

}
}
