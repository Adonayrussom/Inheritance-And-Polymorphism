using System;

namespace sess07_inheritance_and_polymorphism
{
    /// <summary>
    /// Abstract base class for mammals
    /// </summary>
    public abstract class Mammal : Animal
    {
        //Instance field
        protected string habitat;

        //Instance methods
        public abstract void Eat(string diet);
        public void MultiplyMammal(string name)
        {
            Console.WriteLine($"{name} gives birth to young ones.");
        }
    }
}
