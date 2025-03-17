﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.NetworkInformation;
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
                return top == data.Length-1;
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

        public int Capacity
        {
            get { return this.data.Length; }
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

        public T Pop()
        {
            if (this.IsEmpty)
                throw new InvalidOperationException();

            T valor;
            valor = data[top];
            data[top] = default;
            top--;

            return valor;
        }
        public T Peek()
        {
            if (this.IsEmpty)
                throw new InvalidOperationException();

            return data[top];

        }

        public void Push(T item)
        {
            if (IsFull)
                throw new StackOverflowException();

            //data[++top] = item;

            top++;
            data[top] = item;
        }

        public T[] ToArray()
        {
            throw new Exception();
        }

        public int EnsureCapacity(int newCapacity)
        {
            //mirar si la nova capacitat és major que l'actual
            if(this.Capacity < newCapacity) {
                //si la nova capacitat és major

                //crear un nou array amb la nova capacitat
                T[] data2 = new T[newCapacity];

                //copiar les dades al array
                for (int i = 0; i < this.Count; i++)
                    data2[i] = this.data[i];

                //assignar el nou array a la variable data de la pila
                this.data = data2;
            }

            //retorna la capacitat actual de la pila
            return this.Capacity;
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
