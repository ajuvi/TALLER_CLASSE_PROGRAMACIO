using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILA
{
    public class EnumeradorPila2<T> : IEnumerator<T>
    {
        private Pila<T> pila;
        private int posicio;

        public EnumeradorPila2(Pila<T> pila)
        {
            this.pila = pila;
            this.posicio = pila.Count;
        }

        public T Current {
            get
            {
                return pila[posicio];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        public void Dispose(){}

        public bool MoveNext()
        {
            this.posicio--;
            return posicio >= 0;
        }

        public void Reset()
        {
            this.posicio = pila.Count;
        }
    }
}
