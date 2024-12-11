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
            } while (tecla.Key != ConsoleKey.D0);


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

            if (nomEquip != null)
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
            while (!trobat && linia != null)
            {
                abreviaturaFitxer = fTeams.ReadLine();
                if (abreviatura == abreviaturaFitxer)
                {
                    trobat = true;
                    nomEquip = linia;
                }
                else linia = fTeams.ReadLine();
            }

            return nomEquip;
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
            string abreviatura;
            string nomEquip;
            int gols;

            Console.Write("ENTRA UNA ABREVIATURA: ");
            abreviatura = Console.ReadLine();

            nomEquip = GetTeam(fileTeams, abreviatura);

            if (nomEquip == null)
                Console.WriteLine("NO S'HA TROBAT L'EQUIP");
            else
            {
                gols = GetGoalsTeam(fileMatches, abreviatura);
                Console.WriteLine($"L'EQUIP {nomEquip} HA FET {gols} GOLS");
            }

            MsgNextScreen("PREM UNA TECLA PER TORNAR AL MENÚ PRINCIPAL");
        }

        /// <summary>
        /// Retorna el total de gols  fets durant tota la temporada per l'equip amb l'abreviatura paràmetre
        /// </summary>
        /// <param name="fileMatches">fitxer que conté tots els partits</param>
        /// <param name="abreviatura">abreviatura de l'equip. L'abreviatura ha d'existir</param>
        /// <returns>el total de gols fets per l'equip amb l'abreviatura donada pel paràmetre 'abreviatura'</returns>
        public static int GetGoalsTeam(string fileMatches, string abreviatura)
        {
            StreamReader fMatches;
            string linia;
            string data, abreviaturaLocal, abreviaturaVisitant;
            int golsLocal, golsVisitant;
            int gols = 0;

            fMatches = new StreamReader(fileMatches);
            linia = fMatches.ReadLine();

            while (linia != null)
            {
                data = linia;
                abreviaturaLocal = fMatches.ReadLine();
                golsLocal = Convert.ToInt32(fMatches.ReadLine());
                abreviaturaVisitant = fMatches.ReadLine();
                golsVisitant = Convert.ToInt32(fMatches.ReadLine());

                if (abreviatura == abreviaturaLocal)
                    gols = gols + golsLocal;
                else if (abreviatura == abreviaturaVisitant)
                    gols = gols + golsVisitant;

                linia = fMatches.ReadLine();
            }

            return gols;
        }

        /// <summary>
        /// Demana per teclat una data vàlida, una abreviatura vàlida de l'equip local,
        /// una abreviatura vàlida de l'equip visitant i cerca en el fitxer fileMatches
        /// el resultat del partit disputat pels dos equips en la data donada.
        /// Si la data és no vàlida, o alguna abreviatura és no vàlida o no es troba un
        /// partit dels dos equips en la data donada, es donarà el missatge d'error corresponent
        /// i es tornarà al menú principal
        /// </summary>
        /// <param name="fileTeams"></param>
        /// <param name="fileMatches"></param>
        public static void DoGetMatch(string fileTeams, string fileMatches)
        {
            int data, dia, mes, any;
            string strDate;
            string abvLocal, abvVisitant;
            string nomEquipLocal, nomEquipVisitant;
            string infoPartit;

            Console.Write("\nENTRA UNA DATA: ");
            data = Convert.ToInt32(Console.ReadLine());

            dia = data / 1000000;
            mes = data / 10000 % 100;
            any = data % 10000;

            strDate = $"{dia:0:00}/{mes:0:00}/{any:0:0000}";

            if (ValidDate(dia, mes, any))
            {
                Console.Write("ENTRA ABREVIATURA DE L'EQUIP LOCAL: ");
                abvLocal = Console.ReadLine();
                nomEquipLocal = GetTeam(fileTeams,abvLocal);
                if (nomEquipLocal!=null)
                {
                    Console.WriteLine("ENTRA ABREVISTURA DE L'EQUIP VISITANT: ");
                    abvVisitant = Console.ReadLine();
                    nomEquipVisitant = GetTeam(fileMatches, abvVisitant);
                    if (nomEquipVisitant != null)
                    {
                        //buscar la informació de l'equip
                        infoPartit = GetMatch(fileMatches, 
                                              abvLocal, 
                                              nomEquipLocal, 
                                              abvVisitant, 
                                              nomEquipVisitant, 
                                              strDate);

                    }
                    else
                        Console.WriteLine($"NO EXISTEIX L'EQUIP {abvVisitant}");
                }
                else
                    Console.WriteLine($"NO EXISTEIX L'EQUIP {abvLocal}");
            }
            else
                Console.WriteLine("LA DATA NO ÉS VÀLIDA");


            MsgNextScreen("PREM UNA TECLA PER TORNAR AL MENÚ PRINCIPAL");
        }

        /// <summary>
        /// retorna un string en format DATA:09/04/2023 PARTIT : LIVERPOOL 2 - 2 ARSENAL
        /// </summary>
        /// <param name="fileMatches">fitxer que conté tots els partits</param>
        /// <param name="homeTeamABV">abreviatura de l'equip local. Ha d'existir</param>
        /// <param name="homeTeamName">nom de l'equip local.</param>
        /// <param name="awayTeamABV">abreviatura de l'equip visitant. Ha d'existir</param>
        /// <param name="awayTeamName">nom de l'equip visitant./param>
        /// <param name="data">data del partit en format dd/mm/aaaa</param>
        /// <returns>retorna un string en format DATA: 21/12/2023 PARTIT : Manchester City 2 - 1 Liverpool
        /// Si no es troba, retornem null </returns>
        public static string GetMatch(string fileMatches, string homeTeamABV, string homeTeamName, string awayTeamABV, string awayTeamName, string data)
        {
            return "";
        }

        /// <summary>
        /// valida una data a partir del dia, mes i any donats d'acord als criteris següents:
        /// La data ha de pertànyer al rang de dates entre 01/01/2022 i 31/12/2023, ja que és l'únic rang de dates on poden haver-hi partits
        /// i la data ha de ser vàlida
        /// </summary>
        /// <param name="dia">dia del mes</param>
        /// <param name="mes">mes entre 1 i 12</param>
        /// <param name="any">any entre 2022 i 2023</param>
        /// <returns>true si la data és vàlida</returns>
        public static bool ValidDate(int dia, int mes, int any)
        {
            bool esValid=false;

            if(any>=2022 && any <= 2023)
            {
                if(mes>=1 && mes <= 12)
                {
                    if(mes==1 || mes==3 || mes== 5 || mes==7 || mes==8 || mes==10 || mes == 12)
                        esValid = dia >= 1 && dia <= 31;
                    else if (mes ==2)
                        esValid = dia >= 1 && dia <= 28;
                    else
                        esValid = dia >= 1 && dia <= 30;
                }
            }


        }

        /// <summary>
        /// Demana abreviatura de l'equip i mostra els punts obtinguts per l'equip durant tota la temporada
        /// Si l'equip no es troba en el fitxer fileTeams, informem de l'error
        /// </summary>
        /// <param name="fileTeams"></param>
        /// <param name="fileMatches"></param>
        public static void DoGetPointsTeam(string fileTeams, string fileMatches)
        {
            Console.WriteLine("\nNOT IMPLEMENTED YED");
            MsgNextScreen("PREM UNA TECLA PER TORNAR AL MENÚ PRINCIPAL");
        }

        /// <summary>
        /// Retorna els punts fets per l'equip amb l'abreviatura 
        /// durant tota la temporada. Si l'equip guanya, obté 3 punts i si empata n'obté 1
        /// </summary>
        /// <param name="fileTeams"></param>
        /// <param name="abreviatura"></param>
        /// <returns></returns>
        public static int GetPointsTeam(string fileMatches, string abreviatura)
        {
            return 0;
        }


        /// <summary>
        /// abreviatura coincideix amb l'equip local (homeFileAbv) o bé és visitant. 
        /// Volem saber els punts obtinguts per l'equip "abreviatura". Tant "abreviatura" com "homeFileAbv" han
        /// de ser abreviatures d'equips vàlides.
        /// </summary>
        /// <param name="abreviatura">abreviatura de l'equip del qual volem saber els punts en un partit</param>
        /// <param name="homeFileAbv">abreviatura del nom de l'equip que juga com a local. Pot coincidir amb "abreviatura"
        /// o pot no coincidir (en aquest cas, l'equip "abreviatura" jugaria com a visitant</param>
        /// <param name="gHome">gols fets per l'equip local</param>
        /// <param name="gAway">gols fets per l'equip visitant</param>
        /// <returns></returns>
        public static int GetPointsOfMatch(string abreviatura, string homeFileAbv, int gHome, int gAway)
        {
            return 0;
        }
    }
}
