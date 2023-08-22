using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_consept
{
    using System;

    namespace OOPConceptsDemo
    {
        // Encapsulation: Using private fields and public methods to control access
        class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

        // Abstraction: Defining abstract class with abstract and non-abstract methods
        abstract class Shape
        {
            public abstract double Area(); // Abstract method

            public void DisplayArea()
            {
                Console.WriteLine($"Area: {Area()}");
            }
        }

        // Inheritance: Creating derived classes
        class Circle : Shape
        {
            private double radius;

            public Circle(double r)
            {
                radius = r;
            }

            public override double Area()
            {
                return Math.PI * radius * radius;
            }
        }

        class Rectangle : Shape
        {
            private double length;
            private double width;

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }

            public override double Area()
            {
                return length * width;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Encapsulation Example
                Person person = new Person();
                person.Name = "Samruddhi ";
                person.Age = 22;
                person.DisplayInfo();

                // Abstraction and Inheritance Example
                Shape circle = new Circle(5);
                circle.DisplayArea();
                

                Shape rectangle = new Rectangle(4, 6);
                rectangle.DisplayArea();
                Console.ReadLine();
                Console.Readline();
            }
        }
    }

}
