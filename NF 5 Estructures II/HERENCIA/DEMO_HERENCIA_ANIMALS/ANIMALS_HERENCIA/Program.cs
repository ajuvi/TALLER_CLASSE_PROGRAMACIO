using ANIMALS_HERENCIA.MODELS;

namespace ANIMALS_HERENCIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test #1");
            Console.WriteLine("-------");

            //Crear un gos, un gat i un animal
            Dog dog1 = new Dog("0001", "Milú", 10);
            Cat cat1 = new Cat("0002", "Gatsby", 15);
            Animal a1 = new Animal("0003","Turtle",80);

            //El gat caça tres ratolins           
            cat1.CaptureMouse();
            cat1.CaptureMouse();
            cat1.CaptureMouse();
            Console.WriteLine("-------");

            //Cridem el mètode Eat
            cat1.Eat();
            dog1.Eat();
            a1.Eat();
            Console.WriteLine("-------");

            //Cridem el mètode MakeSound
            cat1.MakeSound();
            dog1.MakeSound();
            a1.MakeSound();
            Console.WriteLine("-------");

            //Mostra el ToString de cada objecte
            Console.WriteLine(dog1);
            Console.WriteLine(cat1);
            Console.WriteLine(a1);

            Console.WriteLine();

            Console.WriteLine("Test #2: POLIMORFISME");
            Console.WriteLine("-------");

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("0001", "Milú", 10));
            animals.Add(new Cat("0002", "Gatsby", 15));
            animals.Add(new Animal("0003", "Turtle", 80));

            foreach(Animal a in animals)
            {
                Console.WriteLine(a);
                a.MakeSound();
                Console.WriteLine();
            }

        }
    }
}
