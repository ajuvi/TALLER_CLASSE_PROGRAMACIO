using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace INVENTARI
{
    internal class Inventari
    {
        private const string FILE_NAME = "INVENTARI.CSV";
        private const int MAX_PRODUCTES = 100000;
        private Producte[] productes;
        private int nElem;

        public Inventari() {
            nElem = 0;
            productes = new Producte[MAX_PRODUCTES];
        }

        /// <summary>
        /// Obtenir la suma del ValorTotal de 
        /// tots els productes del magatzem.
        /// </summary>
        public double ValorTotal
        {
            get
            {
                double total = 0;

                //recorrer tots els productes i anar sumant el valor total de cada producte

                return total;
            }
        }

        /// <summary>
        /// Llegeix tots els productes del fitxer INVENTARI.CSV
        /// i els afageix a l'inventari.
        /// </summary>
        public void CarregarInventari()
        {
            StreamReader sr = new StreamReader("INVENTARI.CSV");
            string[] parts;
            string linia;
            sr.ReadLine(); //llegir la capçalera
            linia = sr.ReadLine(); //llegir la primera línia amb informació
            while (linia != null)
            {
                parts = linia.Split(';'); //converteix la línia en un array
                int id = Convert.ToInt32(parts[0]);
                string nom = parts[1];
                double preu = Convert.ToDouble(parts[2]);
                int quantitat = Convert.ToInt32(parts[3]);
                string categoria = parts[4];

                Producte nouP = new Producte(id, nom, preu, quantitat, categoria);

                productes[nElem] = nouP;
                nElem++;

                linia = sr.ReadLine();
            }
        }

        /// <summary>
        /// Mostra per pantalla la quantitat total de productes que hi ha al magatzem 
        /// i seguidament mostra tots els productes del magatzem.
        /// </summary>
        public void LlistarProductes()
        {
            Console.WriteLine($"PRODUCTES MAGATZEM: {this.nElem}");
            Console.WriteLine("------------------------");

            for (int i = 0; i < nElem; i++)
            {
                Console.WriteLine(productes[i]);
            }
        }

        /// <summary>
        /// Obtenir un producte a partir d'un identificador passat per paràmetre (id).
        /// Si el producte no existeix al magatzem llavors el mètode ha de retornar null.
        /// </summary>
        /// <param name="id">Identificador del producte.</param>
        /// <returns>Retorna el producte si aquest està al magatzem, 
        /// o bé retorna un null si el producte no existeix.</returns>
        public Producte GetProducteById(int id)
        {
            //és una cerca
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retorna cert si un producte existeix al magatzem, altrament retorna fals.
        /// Utilitza el mètode GetProducteById per saber si el producte existeix. 
        /// </summary>
        /// <param name="id">Codi del producte</param>
        /// <returns>Retorna true si existeix un producte al magatzem 
        /// amb el codi de producte passat per paràmetre, altrament
        /// retorna fals</returns>
        public bool ExisteixProducte(int id)
        {
            //bool existeix;

            //if (GetProducteById(id) == null)
            //    existeix = false;
            //else
            //    existeix = true;

            //return existeix;

            return GetProducteById(id) != null;
        }

        /// <summary>
        /// Afegeix a l'array de productes un nou producte passat per paràmetre.
        /// No s'ha de poder afegir un producte amb un codi que ja existeix en el magatzem.
        /// </summary>
        /// <param name="nouProducte">Producte a afegir al magatzem</param>
        /// <exception cref="Exception">El codi de producte ja existeix al magatzem</exception>
        public void AfegirProducte(Producte nouProducte)
        {
            if (ExisteixProducte(nouProducte.Id))
                throw new Exception("NO ES POT AFEGIR EL PRODUCTE DONCS EL CODI DE\r\nPRODUCTE ESTÀ REPETIT.");
                        
             //afegir el producte a darrera de l'últim producte
             //incrementar nElem perquè hi ha un producte més a l'array

        }

        /// <summary>
        /// Incrementa o decrementa una quantitat de producte.
        /// </summary>
        /// <param name="id">Codi del producte a incrementar o decrementar.</param>
        /// <param name="increment">Increment (o decrement) de producte.</param>
        /// <exception cref="Exception">Es genera un error si el codi del producte no existeix.</exception>
        public void AfegirQuantitat(int id, int increment)
        {
            Producte p = GetProducteById(id);
            if (p == null)
            {
                throw new Exception("EL PRODUCTE A AFEGIR UNA QUANTIAT D'ESTOC NO EXISTEIX");
            }

            //incrementar la quantitat del producte p

            throw new NotImplementedException();
        }

        /// <summary>
        /// Genera un text en CSV que conté les capçaleres seguit de tots els productes.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str;
            str = "Id;Num;Preu;Quantitat;Tipus\n";

            //recorrer tots els productes i afegir les linia a str
            //for
                //str += $"{};{};{};{};{}"


            return str;

        }

        /// <summary>
        /// Elimina un producte del magatzem. 
        /// </summary>
        /// <param name="id">Codi del producte a eliminar.</param>
        /// <exception cref="Exception">El codi del producte no existeix al magatzem.</exception>
        public void EliminarProducte(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Guarda les dades del producte al fitxer FILE_NAME. 
        /// Primer has d'escriure la capçalera del 
        /// fitxer csv i després escriure tots els 
        /// productes del magatzem.
        /// </summary>
        public void GuardarInventari()
        {

            //StreamWriter

            //què el this?

            throw new NotImplementedException();
        }

    }
}
