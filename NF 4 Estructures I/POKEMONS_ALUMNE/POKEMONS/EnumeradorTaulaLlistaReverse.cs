﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONS
{
    internal class EnumeradorTaulaLlistaReverse<T> : IEnumerator<T>
    {

        private T[] dades;
        private int nElem;
        private int posicio;
        public EnumeradorTaulaLlistaReverse(T[] dades, int nElem)
        {
            this.dades = dades;
            this.nElem = nElem;
            this.posicio =nElem;
        }
        public T Current
        {
            get
            {
                return dades[posicio];
            }

        }

        object IEnumerator.Current {
            get
            {
                return this.Current;
            }
        }

        public bool MoveNext()
        {
            posicio--;

            return posicio >= 0 && posicio < nElem;
        }

        public void Reset()
        {
            posicio = nElem;
        }
        public void Dispose()
        {
        }

    }
}
