using System;

namespace sess07_inheritance_and_polymorphism
{
    /// <summary>
    /// Program that demonstrates the concept of inheriting from abstract classes and creating an
    /// instance of the Bat class.
    /// </summary>
    public class DemoBat : Bat
    {
        static void Main(string[] args)
        {
            //Declare and instantiate a Bat object
            DemoBat batman = new DemoBat();

            //Set the field values derived from the Animal and Mammal abstract class
            batman.food = "fruits & insects";//Derived from the animal class
            batman.activity = "Bats are nocturnal";//Derived from the animal class
            batman.habitat = "Batcave in Gotham City";//Derived from the mammal class

            //Display the behaviour of the Demobat object/instance
            batman.DisplayDetails();
        }

        private void DisplayDetails()
        {
            Console.WriteLine($"\nDetails of the bat" +
                $"\n---------------------------------------");
            Console.WriteLine($"\nDiet: "); this.Eat(food);
            Console.WriteLine($"\nNumber of wings: {WINGS}" +
                $"\nNumbe of legs: {LEGS}" +
                $"\nNumber of ears: {EARS}" +
                $"\nHabitat: {this.habitat}" +
                $"\nBehaviour: {this.activity}");
            Console.WriteLine($"\nReproduction:"); MultiplyMammal("\nBat");
            Console.WriteLine($"\n---------------------------------------");
        }
    }
}
