using System;

namespace AnimalSoundsApp
{
    // Base class for all animals
    public class Animal
    {
        // Virtual method that can be overridden by derived classes
        public virtual void MakeSound()
        {
            // Default implementation for generic animal sound
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class from Animal
    public class Dog : Animal
    {
        // Override the base class method to provide specific implementation
        public override void MakeSound()
        {
            // Dog-specific sound implementation
            Console.WriteLine("Bark");
        }
    }

    // Another derived class from Animal
    public class Cat : Animal
    {
        // Override the base class method to provide specific implementation
        public override void MakeSound()
        {
            // Cat-specific sound implementation
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the base Animal class
            Animal genericAnimal = new Animal();
            Console.Write("Generic animal sound: ");
            genericAnimal.MakeSound();  // Calls base class implementation

            // Create an instance of Dog (derived class)
            Dog myDog = new Dog();
            Console.Write("Dog sound: ");
            myDog.MakeSound();  // Calls Dog's overridden method

            // Create an instance of Cat (derived class)
            Cat myCat = new Cat();
            Console.Write("Cat sound: ");
            myCat.MakeSound();  // Calls Cat's overridden method

            // Bonus: Demonstrate polymorphism
            Console.WriteLine("\nDemonstrating polymorphism:");
            
            // Create Animal reference pointing to Dog instance
            Animal polyAnimal = new Dog();
            Console.Write("Animal reference to Dog: ");
            polyAnimal.MakeSound();  // Outputs "Bark" - runtime type determines behavior
            
            // Create Animal reference pointing to Cat instance
            polyAnimal = new Cat();
            Console.Write("Animal reference to Cat: ");
            polyAnimal.MakeSound();  // Outputs "Meow" - runtime type determines behavior

            // Keep console window open until key press
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}