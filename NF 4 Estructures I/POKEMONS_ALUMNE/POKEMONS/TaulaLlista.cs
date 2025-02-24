using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONS
{
    public class TaulaLlista<T> : ICollection<T>
    {
        const int LONGITUD_INICIAL = 10;
        private T[] dades;
        private int nElem;

        public TaulaLlista()
        {
            nElem = 0;
            dades = new T[LONGITUD_INICIAL];
        }
        private void DoubleCapacity()
        {
            int longitud = dades.Length * 2;
            T[] dades2 = new T[longitud];

            for (int i = 0; i < nElem; i++)
                dades2[i] = dades[i];

            dades = dades2;
        }

        private int IndexOf(T item)
        {
            int index = 0;
            bool trobat = false;
            while(!trobat && index < nElem)
            {
                if (dades[index].Equals(item))
                    trobat = true;
                else index++;
            }

            if (!trobat) index = -1;
            return index;
        }


        //public int Count => nElem;
        public int Count
        {
            get
            {
                return nElem;
            }
        }

        public bool IsReadOnly{
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            if (IsReadOnly) throw new NotSupportedException();

            //1) Mirar si la llista està plena
            if (dades.Length == Count)
                //1.1) Si llista plena duplicar la capacitat
                DoubleCapacity();

            //2) Afegir l'element item al final de la llista
            dades[nElem] = item;

            //3) Actualitzar nElem 
            nElem++;

        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
