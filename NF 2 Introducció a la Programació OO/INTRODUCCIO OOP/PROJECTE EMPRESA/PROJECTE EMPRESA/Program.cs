using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTE_EMPRESA
{
    internal class Program
    {

        //PROGRAMA EXEMPLE DE LA PART II

        //Console.OutputEncoding = Encoding.UTF8;

        ////Crear els empleats
        //Employee e1, e2, e3;

        //e1 = new Employee(1, "Pere", "Vidal", 12000, 0.2, new DateTime(1995, 12, 01));
        //e2 = new Employee(2, "Maria", "Esteve", 15000, 0.3, new DateTime(2021, 02, 15));
        //e3 = new Employee(1, "Laura", "Juvé", 15000, 0.2, new DateTime(2016, 12, 05));

        ////1) Propietats FirstName i LastName
        //Console.WriteLine("\nASSIGNAR EL NOM I EL COGNOM A L'EMPLEAT 1:");
        //e1.FirstName = "artur";
        //e1.LastName = "juvé";
        //Console.WriteLine($"{e1.FirstName} {e1.LastName}"); //S'han de mostrar els cognoms en majúscules.

        ////2) Propietats SalariTotal i AnysTreballats
        //Console.WriteLine("\nSALARI TOTAL I ANYS TREBALLATS DE EMPELAT 1:");
        //Console.WriteLine(e1.SalariTotal);
        //Console.WriteLine(e1.AnysTreballats);

        ////3) Propietat TeNomGuay
        //Console.WriteLine("\nEMPLEAT 1 TÉ NOM GUAI?");
        //Console.WriteLine(e1.TeNomGuay);

        ////4) Mètòde privat SalariToCategory. No es pot cridar des de fora de la classe doncs és privat.
        //Console.WriteLine("\nEL MÈTODE SalariToCategoria ÉS PRIVAT I NO ES POT CRIDAR A FORA DE LA CLASSE");
        ////Console.WriteLine(e1.SalariToCategory());

        ////5) Propietat Category
        //Console.WriteLine("\nCATEGORIA DE EMPLEAT 1:");
        //Console.WriteLine(e1.Category);

        ////6) public static Employee BestEmployee(Employee e1, Employee e2)
        //Console.WriteLine("\nMILLOR EMPLEAT DE E1 I E2:");
        //Console.WriteLine(Employee.BestEmployee(e1, e2));

        ////7) public static double SalaryRaise(Employee e, double increment)
        //Console.WriteLine("\nINCREMENTAR EL SALARI 1000€ DE L'EMPLEAT 1");
        //Console.WriteLine(Employee.SalaryRaise(e1,1000));

        ////8) public double SalaryRaise(Employee e, double increment)
        //Console.WriteLine("\nINCREMENTAR EL SALARI 1000€ DE L'EMPLEAT 1");
        //Console.WriteLine(e1.SalaryRaise(1000));


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
