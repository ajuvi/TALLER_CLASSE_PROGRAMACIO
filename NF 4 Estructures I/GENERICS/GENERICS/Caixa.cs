using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERICS
{
    public  class Caixa<T>
    {
        private T contingut; 
        public void Afegir(T element) { 
            contingut = element; 
        }
        public T Obtenir() { 
            return contingut; 
        }
    }
}
