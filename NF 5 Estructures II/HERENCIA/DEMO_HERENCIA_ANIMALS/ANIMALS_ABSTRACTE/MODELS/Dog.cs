using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANIMALS_ABSTRACTE.MODELS
{
    public class Dog : Animal
    {
        public Dog(string code, string name, int age) : base(code, name, age)
        { }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("GUAU GUAU!");
        }

        public override void Eat()
        {
            Console.WriteLine("Gos menjant.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Gos dormint");
        }
    }
}
