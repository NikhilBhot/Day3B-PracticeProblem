using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B_PracticeProblem
{

    // Base class with different access modifiers
    class MyBaseClass
    {
        public int publicField;
        protected int protectedField;
        private int privateField;

        public MyBaseClass()
        {
            publicField = 1;
            protectedField = 2;
            privateField = 3;
        }

        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod called.");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("ProtectedMethod called.");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("PrivateMethod called.");
        }

        public void AccessPrivateMethod()
        {
            PrivateMethod(); // Accessible within the class
        }
    }

    // Derived class inheriting from MyBaseClass
    class MyDerivedClass : MyBaseClass
    {
        public void AccessProtectedMethod()
        {
            ProtectedMethod(); // Accessible within the derived class
        }
    }

    public class AccessModifer
    {
       public static void AccessModifierMethod()
        {
            MyBaseClass baseObj = new MyBaseClass();

            // Access public members
            Console.WriteLine("Public Field: " + baseObj.publicField);
            baseObj.PublicMethod();
            Console.WriteLine();

            // Access protected members through derived class
            MyDerivedClass derivedObj = new MyDerivedClass();
            derivedObj.AccessProtectedMethod();
            Console.WriteLine();

            // Access private method through public method
            baseObj.AccessPrivateMethod();
        }
    }
}
