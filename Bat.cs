using System;

namespace sess07_inheritance_and_polymorphism
{
    /// <summary>
    /// Class that inherits from the mammal class and will be used to create Bat objects/instances
    /// </summary>
    public class Bat : Mammal
    {
        //Declare instance constant fields
        public const byte WINGS = 2;
        public const byte LEGS = 2;
        public const byte EARS = 2;
        public override void Eat(string diet)
        {
            Console.WriteLine($"The bat eats: {diet}");
        }

        public void DisplayBatBehaviour()
        {
            Console.WriteLine($"\nThe bat flies.");
        }
    }
}
