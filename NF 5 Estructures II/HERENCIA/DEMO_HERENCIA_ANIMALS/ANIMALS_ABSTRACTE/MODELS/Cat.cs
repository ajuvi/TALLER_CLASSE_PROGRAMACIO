using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANIMALS_ABSTRACTE.MODELS;

namespace ANIMALS_ABSTRACTE.MODELS
{
    public class Cat : Animal
    {
        private int mouseCounter;
        public Cat(string code, string name, int age) : base(code, name, age)
        { this.mouseCounter = 0; }
        public override void MakeSound()
        {
            Console.WriteLine("MIAU MIAU!");
        }
        public int MouseCounter
        { 
            get { return mouseCounter; } 
        }
        public override string ToString()
        {
            return base.ToString() + ";" + mouseCounter;
        }
        public void CaptureMouse()
        {
            mouseCounter++;
            Console.WriteLine("He caçat un ratolí.");
        }

        public override void Eat()
        {
            Console.WriteLine("Gat menjant.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Gat dormint.");
        }
    }
}


