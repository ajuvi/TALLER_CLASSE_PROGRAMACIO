using ElementEmpleat;

namespace IntroOPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarem dos variables de tipus empleat
            Employee e1, e2;

            //crear dos objectes de tipus Employees
            e1 = new Employee(100, "Steven", "King", 24000, 0.05, new DateTime(1987, 06, 17));
            e2 = new Employee(101, "Neena", "Kochar", 17000);

            //mostrar el cognom de cada empleat
            Console.WriteLine("COGNOM EMPLEAT1: " + e1.GetLastName());
            Console.WriteLine("COGNOM EMPLEAT2: " + e2.GetLastName());

            //modificar la comissió de cada empleat
            e1.SetCommission(0.25);
            e2.SetCommission(0.15);

            //mostrar els empleats
            Console.WriteLine();
            Console.WriteLine(e1);
            Console.WriteLine(e2);

            //mostrar el salari total de cada empleat
            Console.WriteLine();
            Console.WriteLine("SALARI TOTAL EMPLEAT1: " + e1.SalariTotal() + "$");
            Console.WriteLine("SALARI TOTAL EMPLEAT2: " + e2.SalariTotal() + "$");
        }
    }
}
