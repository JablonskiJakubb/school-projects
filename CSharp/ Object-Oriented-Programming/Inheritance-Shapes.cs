using System;

namespace Inheritance
{
    internal class Program
    {
        class Shape
        {
            public virtual float CalculateArea()
            {
                return 0;
            }
            public virtual float CalculatePerimeter() 
            {
                return 0;
            }
        }

        class Rectangle : Shape
        {
            private float width;
            private float height;
            
            public void SetDimensions(float w, float h) 
            {
                width = w; height = h;
            }

            public override float CalculateArea() 
            { 
                return width * height;
            }
            
            public override float CalculatePerimeter() 
            { 
                return 2 * (width + height);
            }
        }

        class Circle : Shape
        {
            private float radius;

            public Circle(float r)
            {
                radius = r;
            }

            public void SetRadius(float r) 
            {
                radius = r;
            }
            
            public override float CalculateArea() 
            { 
                return (float)(Math.PI * radius * radius);
            }
            
            public override float CalculatePerimeter()
            {
                return (float)(Math.PI * 2 * radius);
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a shape to calculate:");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Trapezoid");
                Console.WriteLine("4. Rhombus");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: 
                        Rectangle rect = new Rectangle();
                        Console.Write("Enter Width: ");
                        float rectWidth = float.Parse(Console.ReadLine());
                        Console.Write("Enter Height: ");
                        float rectHeight = float.Parse(Console.ReadLine());
                        rect.SetDimensions(rectWidth, rectHeight);
                        Console.WriteLine("Rectangle Area: {0}", rect.CalculateArea()); 
                        Console.WriteLine("Rectangle Perimeter: {0}", rect.CalculatePerimeter());
                        break;

                    case 2:
                        float circRadius = GetValidInput("Enter Radius: ");
                        Circle circ = new Circle(circRadius);
                        Console.WriteLine("Circle Area: {0}", circ.CalculateArea());
                        Console.WriteLine("Circle Perimeter: {0}", circ.CalculatePerimeter());
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice, try again");
                        break;
                }
            }
        }

        private static float GetValidInput(string prompt)
        {
            float result;
            while (true)
            {
                Console.WriteLine(prompt);
                if (float.TryParse(Console.ReadLine(), out result) && result > 0) 
                {
                    return result;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid data, please try again");
                    Console.ResetColor();
                }
            }
        }
    }
}
