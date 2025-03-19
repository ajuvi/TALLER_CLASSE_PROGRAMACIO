using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILA
{
    public class EnumeradorPila<T> : IEnumerator<T>
    {
        private T[] data;
        private int posicio;
        private int posicioIncial;

        public EnumeradorPila(T[] data, int top)
        {
            this.data = data;
            this.posicio = top+1;
            this.posicioIncial = this.posicio;
        }

        public T Current { 
            get 
            {
                return this.data[posicio];
            }
        }

        object IEnumerator.Current {
            get { return this.Current; }       
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            posicio--;
            return posicio >= 0;
        }

        public void Reset()
        {
            this.posicio = this.posicioIncial;
        }
    }
}
