using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANIMALS_HERENCIA.MODELS
{
    public class Animal
    {
        protected string code;
        protected string name;
        protected int age;

        public string Code { get { return code; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Animal(string code, string name, int age)
        { this.code = code; this.name = name; this.age = age; }

        public void Eat()
        { Console.WriteLine("Estic menjant.");}
        public void Sleep()
        { Console.WriteLine("Estic dormint."); }
        public virtual void MakeSound()
        { Console.WriteLine("I LOVE MY OWNER"); }

        public override string ToString()
        {
            return $"{Code};{Name};{Age}";
        }
    }
}

