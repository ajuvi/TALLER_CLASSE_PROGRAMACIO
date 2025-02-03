
using System.Globalization;

namespace INVENTARI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventari inventari = new Inventari();

            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();
                MostrarMenu();

                Console.Write("\nENTRA UNA OPCIÓ: ");
                tecla = Console.ReadKey();

                Console.WriteLine();

                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                        DoCarregarProductes(inventari);
                        MsgNextScreen("PREM UNA TECLA PER CONTINUAR");
                        break;
                    case ConsoleKey.D2:
                        DoLlistarProductes(inventari);
                        MsgNextScreen("PREM UNA TECLA PER CONTINUAR");
                        break;
                    case ConsoleKey.D3:
                        DoAfegirProducte(inventari);
                        MsgNextScreen("PREM UNA TECLA PER CONTINUAR");
                        break;

                    //FALTA ACABAR D'IMPLEMENTAR LES ALTRES OPCIONS DEL MENÚ

                    case ConsoleKey.D5:
                        DoActualitzarEstoc(inventari);
                        MsgNextScreen("PREM UNA TECLA PER CONTINUAR");
                        break;
                    case ConsoleKey.D6:
                        DoValorTotalEstoc(inventari);
                        MsgNextScreen("PREM UNA TECLA PER CONTINUAR");
                        break;
                    case ConsoleKey.D0:
                        DoGuardarInventari(inventari);
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

        /// <summary>
        /// Procediment que carrega tots els productes del fitxer on es troba l'inventari.
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoCarregarProductes(Inventari inventari)
        {
            try
            {
                inventari.CarregarInventari();                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Procediment que llista tots els productes de l'inventari.
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoLlistarProductes(Inventari inventari)
        {
            inventari.LlistarProductes();
        }

        /// <summary>
        /// Procediment que afegeix un nou producte a l'inventari.
        /// El procediment demana a l'usuari tots els valors d'un producte i l'afageix a l'inventari.
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoAfegirProducte(Inventari inventari)
        {
            try
            {
                int id;
                string nom;
                int quantitat;
                double preu;
                string categoria;

                Console.Write("ID PRODUCTE: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("NOM PRODUCTE: ");
                nom = Console.ReadLine();

                Console.Write("QUANTITAT: ");
                quantitat = Convert.ToInt32(Console.ReadLine());

                Console.Write("PREU: ");
                preu = Convert.ToDouble(Console.ReadLine());

                Console.Write("CATEGORIA: ");
                categoria = Console.ReadLine();

                Producte p = new Producte(id, nom, preu, quantitat, categoria);

                inventari.AfegirProducte(p);

                Console.WriteLine("S'HA AFEGIT EL PRODUCTE:");
                Console.WriteLine(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// El procediment demana el codi de producte i 
        /// l'elimina de l'inventari.
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoEliminarProducte(Inventari inventari)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Procediment que demana a l'usuari el codi d'un producte 
        /// i una quantitat a afegir d'estoc.
        /// El procediment afegeix la quantitat d'estoc al producte.
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoActualitzarEstoc(Inventari inventari)
        {
            try
            {
                Console.Write("ENTRA EL CODI DEL PRODUCTE: ");
                int codi = Convert.ToInt32(Console.ReadLine());

                Console.Write("ENTRA LA QUANTITAT DEL PRODUCTE: ");
                int quantitat = Convert.ToInt32(Console.ReadLine());

                inventari.AfegirQuantitat(codi, quantitat);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Procediment que retorna el valor total de l'estoc que té el magatzem.
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoValorTotalEstoc(Inventari inventari)
        {
            Console.WriteLine($"VALOR TOTAL DE L'ESTOC: {inventari.ValorTotal} EUROS");
        }

        /// <summary>
        /// Procediment que guarda l'inventari a fitxer.
        /// El procediment ha de demanar a l'usuari si vol guardar l'inventari (s/n).
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoGuardarInventari(Inventari inventari)
        {

            //creu que fa falta un try catch????

            //demanar a l'usuari si es vol guardar l'inventari
                //si -> si vol guardar
                //no -> no vol guardar



            throw new NotImplementedException();
        }

        /// <summary>
        /// Procediment que mostra un missatge per pantalla i espera que
        /// l'usuari premi una tecla.
        /// </summary>
        /// <param name="msg"></param>
        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        /// <summary>
        /// Mostra el menú principal del programa
        /// </summary>
        public static void MostrarMenu()
        {
            Console.WriteLine("GESTIÓ DE L'INVENTARI");
            Console.WriteLine("---------------------");
            Console.WriteLine("1- CARREGAR PRODUCTES");
            Console.WriteLine("2- LLISTAR PRODUCTES");
            Console.WriteLine("3- AFEGIR NOU PRODUCTE");
            Console.WriteLine("4- ELIMINAR PRODUCTE");
            Console.WriteLine("5- ACTUALITZAR ESTOC");
            Console.WriteLine("6- VALOR TOTAL ESTOC");
            Console.WriteLine("0- EXIT");
        }



    }
}
