using ANIMALS_ABSTRACTE.MODELS;

namespace ANIMALS_ABSTRACTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LA SEGÜENT LINIA DONA ERROR DONCS LA CLASSE ANIMAL ÉS ABSTRACTE.
            //Animal a1 = new Animal("0003", "Turtle", 80);

            Animal a1 = new Cat("0001", "Felix", 80);

            Console.WriteLine("Test #1");
            Console.WriteLine("-------");

            //Crear un gos, un gat i un altre gos
            Dog dog1 = new Dog("0001", "Milú", 10);
            Cat cat1 = new Cat("0002", "Gatsby", 15);
            Animal a2 = new Dog("0003", "Ideafix", 80);

            dog1.Eat();
            cat1.Eat();
            a2.Eat();

            Console.WriteLine("Test #2: POLIMORFISME");
            Console.WriteLine("-------");

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("0001", "Milú", 10));
            animals.Add(new Cat("0002", "Gatsby", 15));
            animals.Add(new Dog("0003", "Ideafix", 80));

            for(int i=0;i<animals.Count;i++)
            {
                Animal a = animals[i];
                a.Eat();
                a.Sleep();
                Console.WriteLine();
            }
        }
    }
}
