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
        /// Obtenir la suma del ValorTotal de tots els productes del magatzem.
        /// </summary>
        public double ValorTotal
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Llegeix tots els productes del fitxer INVENTARI.CSV
        /// i els afageix a l'inventari.
        /// </summary>
        public void CarregarInventari()
        {
            /*StreamReader sr = new StreamReader("INVENTARI.CSV");
            string[] parts;
            string linia;
            sr.ReadLine(); //llegir la capçalera
            linia = sr.ReadLine(); //llegir la primera línia amb informació
            while (linia != null)
            {
                parts = linia.Split(';'); //converteix la línia en un array
                id = Convert.ToInt32(parts[0]);
                nom = parts[1];
                ...
                linia = sr.ReadLine();
            }*/
        }

        /// <summary>
        /// Mostra per pantalla la quantitat total de productes que hi ha al magatzem 
        /// i seguidament mostra tots els productes del magatzem.
        /// </summary>
        public void LlistarProductes()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Afegeix a l'array de productes un nou producte passat per paràmetre.
        /// No s'ha de poder afegir un producte amb un codi que ja existeix en el magatzem.
        /// </summary>
        /// <param name="nouProducte">Producte a afegir al magatzem</param>
        /// <exception cref="Exception">El codi de producte ja existeix al magatzem</exception>
        public void AfegirProducte(Producte nouProducte)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Incrementa o decrementa una quantitat de producte.
        /// </summary>
        /// <param name="id">Codi del producte a incrementar o decrementar.</param>
        /// <param name="increment">Increment (o decrement) de producte.</param>
        /// <exception cref="Exception">Es genera un error si el codi del producte no existeix.</exception>
        public void AfegirQuantitat(int id, int increment)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Genera un text en CSV que conté les capçaleres seguit de tots els productes.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            throw new NotImplementedException();
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
        /// Guarda les dades del producte al fitxer FILE_NAME. Primer has d'escriure la capçalera del 
        /// fitxer csv i després escriure tots els productes del magatzem.
        /// </summary>
        public void GuardarInventari()
        {
            throw new NotImplementedException();
        }

    }
}
