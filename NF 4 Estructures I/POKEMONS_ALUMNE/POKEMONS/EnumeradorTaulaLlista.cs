using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONS
{
    internal class EnumeradorTaulaLlista<T> : IEnumerator<T>
    {

        private int nElem;
        private int posicio;
        private T[] dades;

        public EnumeradorTaulaLlista(T[] dades, int nElem) { 
            this.dades = dades; 
            this.posicio = -1; 
            this.nElem = nElem; 
        }

        public T Current {
            get {
                return dades[posicio];
            }
        }

        object IEnumerator.Current {
            get {
                return this.Current;
            }
        }

        public bool MoveNext()
        {
            posicio++;

            return posicio >= 0 && posicio < nElem;
        }

        public void Reset()
        {
            posicio = -1;
        }
        public void Dispose()
        {
        }
    }
}
