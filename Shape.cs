using System;

namespace ShapeAreaCalculator
{
    // Step 1: Define abstract base class
    public abstract class Shape
    {
        // Abstract method declaration (no implementation)
        // This forces all derived classes to implement their own version of GetArea()
        public abstract double GetArea();
    }

    // Step 2: Derived class for Circle
    public class Circle : Shape
    {
        // Property to store radius
        public double Radius { get; set; }

        // Constructor to initialize radius
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implement abstract method - provide concrete implementation
        public override double GetArea()
        {
            // Area formula: πr²
            return Math.PI * Radius * Radius;
        }
    }

    // Step 3: Derived class for Rectangle
    public class Rectangle : Shape
    {
        // Properties for dimensions
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor to initialize dimensions
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implement abstract method - provide concrete implementation
        public override double GetArea()
        {
            // Area formula: width × height
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Circle instance with radius 5
            Circle circle = new Circle(5.0);
            // Call GetArea() and display result
            Console.WriteLine($"Area of circle (radius=5): {circle.GetArea():F2}");

            // Create Rectangle instance 4x6
            Rectangle rectangle = new Rectangle(4.0, 6.0);
            // Call GetArea() and display result
            Console.WriteLine($"Area of rectangle (4x6): {rectangle.GetArea()}");

            // Demonstrating polymorphism
            Console.WriteLine("\nUsing base class references:");
            
            // Shape reference to Circle
            Shape shape1 = new Circle(3.0);
            Console.WriteLine($"Circle area via Shape reference: {shape1.GetArea():F2}");
            
            // Shape reference to Rectangle
            Shape shape2 = new Rectangle(5.0, 2.0);
            Console.WriteLine($"Rectangle area via Shape reference: {shape2.GetArea()}");

            // Keep console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}