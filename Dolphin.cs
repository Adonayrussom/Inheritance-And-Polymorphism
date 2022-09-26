using System;

namespace sess07_inheritance_and_polymorphism
{
    /// <summary>
    /// Class that inherits from the mammal class and will be used to create dolphin objects/instances
    /// </summary>
    public class Dolphin : Mammal
    {
        //Declare instance constant fields
        public const byte FLIPPERS = 2;
        public const byte SNOUT = 1;
        public const byte BLOWHOLE = 1;
        public override void Eat(string diet)
        {
            Console.WriteLine($"The dolphin eats: {diet}");
        }

        public void DisplayBatBehaviour()
        {
            Console.WriteLine($"\nThe dolphin swims.");
        }
    }
}
