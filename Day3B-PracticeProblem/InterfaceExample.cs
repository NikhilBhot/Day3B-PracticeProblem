using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B_PracticeProblem
{
    // Interface
    interface IShape
    {
        void Draw();
        double CalculateArea();
    }

    // Circle class implementing IShape
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Rectangle class implementing IShape
    class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }

        public double CalculateArea()
        {
            return width * height;
        }
    }

    public class InterfaceExample
    {
        public static void InterfaceClassDemoMethod()
        {
            // Create objects of Circle and Rectangle
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            // Call methods through interface references
            IShape shape1 = circle;
            shape1.Draw();
            Console.WriteLine("Area: " + shape1.CalculateArea());

            IShape shape2 = rectangle;
            shape2.Draw();
            Console.WriteLine("Area: " + shape2.CalculateArea());
        }
    }
}
