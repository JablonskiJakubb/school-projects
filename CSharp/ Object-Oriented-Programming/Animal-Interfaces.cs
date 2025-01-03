using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        // Task 1
        public interface IAnimal
        {
            void MakeSound();
        }

        public class Dog : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("Woof, Woof, Woof");
            }
        }

        public class Cat : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("Meow, Meow, Meow");
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Console.ReadKey();
            Console.WriteLine();
            dog.MakeSound();
            cat.MakeSound();
            Console.WriteLine();
        }
    }
}

// Task 2

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        public interface IAnimal
        {
            void MakeSound();
            void Eat();
        }

        public abstract class Animal : IAnimal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Animal(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public abstract void MakeSound();

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating");
            }
        }

        public class Dog : Animal
        {
            public Dog(string name, int age) : base(name, age) { }

            public override void MakeSound()
            {
                Console.WriteLine("Woof, Woof, Woof");
            }

            public void Eat()
            {
                // Dog-specific eating behavior can be implemented here if needed
            }
        }

        public class Cat : Animal
        {
            public Cat(string name, int age) : base(name, age) { }

            public override void MakeSound()
            {
                Console.WriteLine("Meow, Meow, Meow");
            }

            public void Eat()
            {
                // Cat-specific eating behavior can be implemented here if needed
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog("Azor", 2);
            Cat cat = new Cat("Filemon", 3);
            dog.MakeSound();
            dog.Eat();
            cat.MakeSound();
            cat.Eat();
        }
    }
}

// Creating an animal list:

// Create a List<IAnimal> to store dog and cat objects with their respective names and ages

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        public interface IAnimal
        {
            void MakeSound();
            void Eat();
        }

        public abstract class Animal : IAnimal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Animal(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public abstract void MakeSound();

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating");
            }
        }

        public class Dog : Animal
        {
            public Dog(string name, int age) : base(name, age) { }

            public override void MakeSound()
            {
                Console.WriteLine("Woof, Woof, Woof");
            }

            public void Eat()
            {
                // Dog-specific eating behavior can be implemented here if needed
            }
        }

        public class Cat : Animal
        {
            public Cat(string name, int age) : base(name, age) { }

            public override void MakeSound()
            {
                Console.WriteLine("Meow, Meow, Meow");
            }

            public void Eat()
            {
                // Cat-specific eating behavior can be implemented here if needed
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog("Azor", 2);
            Cat cat = new Cat("Filemon", 3);

            // Create a list of animals
            List<Animal> animalList = new List<Animal>();
            animalList.Add(dog);
            animalList.Add(cat);

            // Iterate through the list of animals
            foreach (var animal in animalList)
            {
                animal.Eat();
                animal.MakeSound();
            }
        }
    }
}
