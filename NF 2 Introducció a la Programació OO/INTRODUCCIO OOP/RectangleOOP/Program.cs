using System.Reflection;

namespace RectangleOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Crear els rectangles de la figura
            Rectangle r1 = new Rectangle(2, 2, 1, 4);
            Rectangle r2 = new Rectangle(2, 2, 2, 3);
            Rectangle r3 = new Rectangle(3, 2, 2, 0);

            //2) Mostrar l’àrea dels rectangles r1 i r2
            Console.WriteLine($"AREA R1: {r1.Area}");
            Console.WriteLine($"AREA R2: {r2.Area}");

            //3) Comprovar si el rectangle r3 és quadrat
            if (r3.EsQuadrat())
                Console.WriteLine("EL RECTANGLE 3 ÉS QUADRAT");
            else
                Console.WriteLine("EL RECTANGLE 3 NO ÉS QUADRAT");

            //4) Calcular l’àrea màxima dels tres rectangles
            double areaMaxima;
            areaMaxima = Math.Max(r1.Area, r2.Area);
            areaMaxima = Math.Max(areaMaxima,r3.Area);

            Console.WriteLine($"AREA MAXIMA: {areaMaxima}");

            //5) Moure el rectangle r1 a la posició(0, 0)
            r1.Moure(0, 0);

            //6) Crear un nou rectangle(r4) sumant els rectangles r2 i r3
            Rectangle r4 = Rectangle.Suma(r2, r3);

            //7 Mostrar els tres rectangles per pantalla
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r4);
        }
    }
}
