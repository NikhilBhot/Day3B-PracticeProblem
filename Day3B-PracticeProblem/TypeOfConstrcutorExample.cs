using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B_PracticeProblem
{
    //Demonstrate different types of constructors.
    public class Person
    {
        private string name;
        private int age;

        // Default Constructor
        public Person()
        {
            name = "Unknown";
            age = 0;
        }

        // Parameterized Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Copy Constructor
        public Person(Person other)
        {
            this.name = other.name;
            this.age = other.age;
        }

        // Static Constructor
        static Person()
        {
            Console.WriteLine("Static Constructor called.");
        }

        // Instance Method
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    public class TypeOfConstrcutorExample
    {
       public static void DemoMethod()
        {
            // Default Constructor
            Person person1 = new Person();
            Console.WriteLine("Default Constructor:");
            person1.DisplayInfo();
            Console.WriteLine();

            // Parameterized Constructor
            Person person2 = new Person("John", 25);
            Console.WriteLine("Parameterized Constructor:");
            person2.DisplayInfo();
            Console.WriteLine();

            // Copy Constructor
            Person person3 = new Person(person2);
            Console.WriteLine("Copy Constructor:");
            person3.DisplayInfo();
        }
    }
}
