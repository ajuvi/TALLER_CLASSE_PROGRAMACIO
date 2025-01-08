using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTE_EMPRESA
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            //1. DECLARAR DOS EMPLEATS
            Employee e1;
            Employee e2;

            //2. CREAR DOS EMPLEATS
            e1 = new Employee(1, "Pere", "Vidal", 12000, 0.2, new DateTime(1995, 12, 01));
            e2 = new Employee(2, "Maria", "Esteve", 15000, 0.3, new DateTime(2021, 02, 15));

            //3. MOSTRAR ELS EMPLEATS PER PANTALLA AMB EL MÈTODE ToString
            Console.WriteLine(e1);
            Console.WriteLine(e2);

            //4. MOSTRAR EL COGNOM DEL PRIMER EMPLEAT
            string cognom;
            cognom = e1.GetLastName();
            Console.WriteLine(cognom);

            //5. ELIMINAR LA COMISSIÓ DELS DOS EMPLEATS
            e1.SetCommission(0);
            e2.SetCommission(0);

            //6. MOSTRAR EL SALARI DEL PRIMER EMPLEAT
            double salari;
            salari = e1.GetSalary("1234");
            Console.WriteLine($"EL SALARI DE {e1.GetLastName()} ÉS {salari}");

            //7. MOSTRAR ELS ANYS TREBALLATS DELS DOS EMPLEATS
            Console.WriteLine($"ANYS TREBALLATS EMPLEAT1: {e1.AnysTreballats():0.00} ANYS");
            Console.WriteLine($"ANYS TREBALLATS EMPLEAT2: {e2.AnysTreballats():0.00} ANYS");

            //8. MOSTRAR ELS EMPLEATS PER PANTALLA AMB EL MÈTODE ToString
            Console.WriteLine(e1);
            Console.WriteLine(e2);

        }
    }
}
