using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONS
{
    public class TaulaLlista<T> : IList<T>
    {
        const int LONGITUD_INICIAL = 10;
        private T[] dades;
        private int nElem;

        private void DoubleCapacity()
        {
            int longitud = dades.Length * 2;
            T[] dades2 = new T[longitud];

            for (int i = 0; i < nElem; i++)
                dades2[i] = dades[i];

            this.dades = dades2;
        }

        public int IndexOf(T item)
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

        public T this[int index] { 
            get
            {
                //if (!(index >= 0 && index < nElem))
                if (index < 0 || index >= nElem)
                    throw new ArgumentOutOfRangeException();

                return this.dades[index];
            } 
            set 
            {
            
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
            if (IsReadOnly) throw new NotSupportedException();

            this.dades = new T[LONGITUD_INICIAL];
            nElem = 0;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }



        public bool Remove(T item)
        {
            if (this.IsReadOnly) 
                throw new NotSupportedException();

            int index = IndexOf(item);

            if(index != -1)
            {
                for (int i = index; i < nElem - 2; i++)
                {
                    dades[i] = dades[i + 1];
                }
                dades[nElem] = default;
                nElem--;
            }

            return index != -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < nElem; i++)
            {
                yield return dades[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
