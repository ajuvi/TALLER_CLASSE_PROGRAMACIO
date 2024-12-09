using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPremier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_MATCHES = "MATCHES.TXT";
            const string FILE_TEAMS = "TEAMS.TXT";

            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();
                MostrarMenu();

                Console.Write("\nENTRA UNA OPCIÓ: ");
                tecla = Console.ReadKey();

                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                        DoSearchTeam(FILE_TEAMS);
                        break;
                    case ConsoleKey.D2:
                        DoGetGoalsTeam(FILE_TEAMS, FILE_MATCHES);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\nNot implemented yed");
                        MsgNextScreen("PREM UNA TECLA PER CONTINUAR");
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("\nNot implemented yed");
                        MsgNextScreen("PREM UNA TECLA PER CONTINUAR");
                        break;
                    case ConsoleKey.D0:
                        Console.WriteLine("\nHAS FINALITZAT EL PROGRAMA.");
                        MsgNextScreen("PREM UNA TECLA PER CONTINUAR");
                        break;
                    default:
                        Console.WriteLine("\nOPCIÓ NO VÁLIDA.");
                        MsgNextScreen("PREM UNA TECLA PER CONTINUAR");
                        break;
                }
            } while (tecla.Key!=ConsoleKey.D0);


        }

        public static void MostrarMenu()
        {
            Console.WriteLine("1- CERCAR EQUIP");
            Console.WriteLine("2- GOLS D'UN EQUIP EN UNA TEMPORADA");
            Console.WriteLine("3- MOSTRAR RESULTAT D'UN PARTIT CONCRET");
            Console.WriteLine("4- PUNTS FETS PER UN EQUIP EN UNA TEMPORADA");
            Console.WriteLine("0- EXIT");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
        /// <summary>
        /// Es demana per teclat l'abreviatura d'un equip i s'informa 
        /// si l'equip existeix o no. 
        /// En cas que existeixi, es mostren les dades de l'equip
        /// </summary>
        /// <param name="fileTeams">fitxer que conté tots els equips</param>
        public static void DoSearchTeam(string fileTeams)
        {
            String targetAvg;
            String nomEquip;

            Console.Write("\nENTRA EL CODI DE L'EQUIP: ");
            targetAvg = Console.ReadLine();

            nomEquip = GetTeam(fileTeams, targetAvg);

            if(nomEquip!=null)
                Console.WriteLine($"NOM EQUIP: {nomEquip}");
            else
                Console.WriteLine("L'EQUIP NO EXISTEIX");


            MsgNextScreen("PREM UNA TECLA PER CONTINUAR.");
        }
        
        /// <summary>
        /// Es retorna el nom de l'equip a partir de la seva abreviatura
        /// </summary>
        /// <param name="fileTeams">fitxer que conté els equips</param>
        /// <param name="abreviatura">abreviatura de l'equip a cercar</param>
        /// <returns>el nom de l'equip trobat en el fitxer fileTeams que tingui com a abreviatura el valor del paràmetre 'abreviatura'
        /// si l'equip no existeix, retornem null</returns>
        public static string GetTeam(string fileTeams, string abreviatura)
        {
            StreamReader fTeams;
            string linia;
            string abreviaturaFitxer;
            string nomEquip = null;
            bool trobat = false;

            fTeams = new StreamReader(fileTeams);
            linia = fTeams.ReadLine();
            while(!trobat && linia != null)
            {
                abreviaturaFitxer = fTeams.ReadLine();
                if (abreviatura == abreviaturaFitxer)
                {
                    trobat = true;
                    nomEquip = linia;
                } else linia = fTeams.ReadLine();
            }

            return nomEquip;
        }
        
        /// <summary>
        /// Retorna el total de gols  fets durant tota la temporada per l'equip amb l'abreviatura paràmetre
        /// </summary>
        /// <param name="fileMatches">fitxer que conté tots els partits</param>
        /// <param name="abreviatura">abreviatura de l'equip. L'abreviatura ha d'existir</param>
        /// <returns>el total de gols fets per l'equip amb l'abreviatura donada pel paràmetre 'abreviatura'</returns>
        public static int GetGoalsTeam(string fileMatches, string abreviatura)
        {
            return 0;
        }
        
        /// <summary>
        /// demana una abreviatura d'equip per teclat. 
        /// Si l'equip existeix, mostra el nom i els gols totals fet per l'equip en tots els seus partits.
        /// Si no existeix, es dona un msg d'error i tornem al menú principal
        /// </summary>
        /// <param name="fileTeams"></param>
        /// <param name="fileMatches"></param>
        public static void DoGetGoalsTeam(string fileTeams, string fileMatches)
        {
            Console.WriteLine("EXECUCIÓ DEL CODI DE l'ACCIÓ DoGetGoalsTeam");
            MsgNextScreen("PREM UNA TECLA PER TORNAR AL MENÚ PRINCIPAL");
        }
 
    }
}
