using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PILA
{
    internal class Pila<T>:ICollection<T>
    {
        const int DEFAULT_SIZE = 5;
        private T[] data;
        private int top;
        
        public Pila()
        {
            top = -1;
            this.data = new T[DEFAULT_SIZE];
        }
        public Pila(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException();

            top = -1;
            this.data = new T[capacity];
        }

        public Pila(IEnumerable<T> items)
        {
            if (items == null)
                throw new ArgumentNullException();

            //HO FAREM QUAN TINGUEM EL MÈTODE
            //EnsureCapacity

        }

        public bool IsEmpty
        {
            get
            {
                //return top < 0;
                return top == -1;

                /*if (top < 0)
                    return true;
                else
                    return false;
                */
            }
        }

        public bool IsFull
        {
            get
            {
                
            }
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > top)
                    throw new ArgumentOutOfRangeException();

                return data[index];
            }
        }

        public int Count
        {
            get {
                return top + 1;
            }
        }

        public bool IsReadOnly
        {
            get {
                return false;
            }
        }

        public void Clear()
        {
            //for (int i = 0; i < Count; i++)
            //    data[i] = default;

            data = new T[data.Length];

            top = -1;
        }

        public void Add(T item)
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
