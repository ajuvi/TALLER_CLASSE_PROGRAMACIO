using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONS
{
    internal class ElMeuEnnumerador<T> : IEnumerator<T>
    {

        private int nElem;
        private int posicio;
        private T[] dades;

        public ElMeuEnnumerador(T[] dades, int nElem) { 
            this.dades = dades; 
            this.posicio = -1; 
            this.nElem = nElem; 
        }

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
        }
    }
}
