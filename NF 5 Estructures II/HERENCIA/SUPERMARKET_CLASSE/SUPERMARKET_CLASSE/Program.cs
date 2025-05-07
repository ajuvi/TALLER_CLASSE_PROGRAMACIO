using SUPERMARKET_CLASSE.MODELS;

namespace SUPERMARKET_CLASSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item.Category categoria;
            categoria = (Item.Category)2;
            Console.WriteLine(categoria);

            Item.Packaging packaging;
            packaging = (Item.Packaging)'U';
            Console.WriteLine(packaging);


        }
    }
}
