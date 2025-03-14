using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONS
{
    internal class EnumeradorTaulaLlistaReverse<T> : IEnumerator<T>
    {
        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
        }
        public void Dispose()
        {
        }

    }
}
