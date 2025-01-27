
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

                    //FALTA ACABAR D'IMPLEMENTAR LES ALTRES OPCIONS DEL MENÚ

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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Procediment que llista tots els productes de l'inventari.
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoLlistarProductes(Inventari inventari)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Procediment que afegeix un nou producte a l'inventari.
        /// El procediment demana a l'usuari tots els valors d'un producte i l'afageix a l'inventari.
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoAfegirProducte(Inventari inventari)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// El procediment demana el codi de producte i l'elimina de l'inventari.
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoEliminarProducte(Inventari inventari)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Procediment que demana a l'usuari el codi d'un producte i una quantitat a afegir d'estoc.
        /// El procediment afegeix la quantitat d'estoc al producte.
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoActualitzarEstoc(Inventari inventari)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Procediment que retorna el valor total de l'estoc que té el magatzem.
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoValorTotalEstoc(Inventari inventari)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Procediment que guarda l'inventari a fitxer.
        /// El procediment ha de demanar a l'usuari si vol guardar l'inventari (s/n).
        /// </summary>
        /// <param name="inventari"></param>
        private static void DoGuardarInventari(Inventari inventari)
        {
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
