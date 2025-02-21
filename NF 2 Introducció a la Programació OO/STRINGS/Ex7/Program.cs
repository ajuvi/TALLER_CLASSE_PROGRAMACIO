using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una cadena de numeros
            string str = "["; 
            for (int i = 0; i < 10; i++) str = str + i +';'; 
            str = str.Substring(0, str.Length - 1); 
            Console.WriteLine(str + "]");

            //Crear una cadena de numeros amb StringBuilder
            StringBuilder sb = new StringBuilder("[");
            for (int i = 0; i < 10; i++) sb.Append(i).Append(';');
            sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            Console.WriteLine(sb.ToString());


        }
    }
}
