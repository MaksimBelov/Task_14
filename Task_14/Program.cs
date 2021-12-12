using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Муська";
            Console.Write("{0} говорит: ", cat.Name);
            cat.Say();
            Console.WriteLine();
            cat.ShowInfo();
            Console.WriteLine();

            Dog dog = new Dog { Name = "Жучка" };
            Console.Write("{0} говорит: ", dog.Name);
            dog.Say();
            Console.WriteLine();
            dog.ShowInfo();
            Console.WriteLine();

            Cat cat1 = new Cat();
            Console.Write("{0} говорит: ", cat1.Name);
            cat1.Say();
            Console.WriteLine();
            cat1.ShowInfo();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public string name;

        public abstract string Name { get; set; }


        public Animal(string name = "Какое-то животное")
        {
            Name = name;
        }

        abstract public void Say();

        public void ShowInfo()
        {
            Console.Write("{0}: ", name);
            Say();
        }
    }

    class Cat : Animal
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }

    class Dog : Animal
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
