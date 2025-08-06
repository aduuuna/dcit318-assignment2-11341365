using System;

namespace MovableInterfaceDemo
{
    // Step 1: Define the IMovable interface
    public interface IMovable
    {
        // Interface method declaration (no implementation)
        // This defines a contract that implementing classes must follow
        void Move();
    }

    // Step 2: Create Car class implementing IMovable
    public class Car : IMovable
    {
        // Implement the Move method from IMovable interface
        public void Move()
        {
            // Specific implementation for Car
            Console.WriteLine("Car is moving");
        }
    }

    // Step 3: Create Bicycle class implementing IMovable
    public class Bicycle : IMovable
    {
        // Implement the Move method from IMovable interface
        public void Move()
        {
            // Specific implementation for Bicycle
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instance of Car
            Car myCar = new Car();
            Console.Write("Car movement: ");
            myCar.Move();  // Calls Car's Move implementation

            // Create instance of Bicycle
            Bicycle myBike = new Bicycle();
            Console.Write("Bicycle movement: ");
            myBike.Move();  // Calls Bicycle's Move implementation

            // Demonstrate polymorphism using interface references
            Console.WriteLine("\nUsing interface references:");
            
            // IMovable reference to Car
            IMovable movable1 = new Car();
            Console.Write("Movable reference to Car: ");
            movable1.Move();  // Outputs "Car is moving"
            
            // IMovable reference to Bicycle
            IMovable movable2 = new Bicycle();
            Console.Write("Movable reference to Bicycle: ");
            movable2.Move();  // Outputs "Bicycle is moving"

            // Show collection of movable objects
            Console.WriteLine("\nProcessing collection of movable objects:");
            IMovable[] vehicles = new IMovable[] { new Car(), new Bicycle() };
            
            foreach (var vehicle in vehicles)
            {
                Console.Write("Current vehicle: ");
                vehicle.Move();  // Calls appropriate implementation based on actual type
            }

            // Keep console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}