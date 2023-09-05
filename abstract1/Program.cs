using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract1
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a shape:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Circle circle = new Circle();
                Console.Write("Enter the radius of the circle: ");
                circle.Radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of the circle: {circle.CalculateArea():F2}");
                Console.ReadLine();
            }
            else if (choice == 2)
            {
                Rectangle rectangle = new Rectangle();
                Console.Write("Enter the width of the rectangle: ");
                rectangle.Width = double.Parse(Console.ReadLine());
                Console.Write("Enter the height of the rectangle: ");
                rectangle.Height = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of the rectangle: {rectangle.CalculateArea():F2}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
    






}
