using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaulaLlistaDinamica
{
    public class TaulaLlistaD<T> : IList<T>
    {
        private Node head;
        private Node tail;
        private int nElem;
        public TaulaLlistaD()
        {
            head = null;
            tail = null;
            nElem = 0;
        }

        private class Node
        {
            private T data;
            private Node next;

            public Node(T dada)
            {
                this.data = dada;
                this.next = null;
            }
            public T Data {
                get { return data; }
                set { data = value; }
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
        }

        public T this[int index]
        {
            get {
                if (index < 0 || index > this.Count)
                    throw new IndexOutOfRangeException();

                Node nodeActual=head;
                for(int i = 0; i < index; i++)
                {
                    nodeActual = nodeActual.Next;
                }

                return nodeActual.Data;
            }

            set {
                if (index < 0 || index > this.Count)
                    throw new IndexOutOfRangeException();

                Node nodeActual = head;
                for (int i = 0; i < index; i++)
                {
                    nodeActual = nodeActual.Next;
                }

                nodeActual.Data = value;
            }
        }

        public int Count {
            get { return this.nElem; }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
        public bool Empty
        {
            get { return Count == 0; }
        }
        public void Clear()
        {
            if (this.IsReadOnly) throw new NotSupportedException();

            this.head = null;
            this.tail = null;
            this.nElem = 0;
        }

        public void Add(T item)
        {
            if (this.IsReadOnly) throw new NotSupportedException();

            Node nouNode = new Node(item);

            if (this.Empty)
            {
                head = nouNode;
                tail = nouNode;
                nElem = 1;
            } else
            {
                //afegir el node al final de la llista
                tail.Next = nouNode;
                tail = nouNode;
            }
        }

        public bool Contains(T item)
        {
            return this.IndexOf(item) >= 0;
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (arrayIndex + nElem > array.Length)
                throw new IndexOutOfRangeException($"NO HI  HA PROU ESPAI");

            int i = 0;
            Node node = head;
            while (node != null)
            {
                array[i++] = node.Data;
                node = node.Next;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public int IndexOf(T item)
        {
            int pos = 0;
            bool trobat = false;
            Node node = head;
            while (node != null && !trobat)
            {
                if (node.Data.Equals(item))
                    trobat = true;
                else
                {
                    pos++;
                    node = node.Next;
                }
            }

            if (!trobat) pos = -1;

            return pos;
        }
        public void Insert(int index, T item)
        {
            if (this.IsReadOnly) throw new NotSupportedException();
            if (index > nElem || index < 0) throw new IndexOutOfRangeException("POSICIÓ NO VÀLIDA A LA LLISTA");

            Node nouNode = new Node(item);

            if (this.Empty)
            {
                this.head = nouNode;
                this.tail = nouNode;
            }
            else if (index == 0)
            {
                nouNode.Next = head;
                head = nouNode;
            } else if (index == nElem)
            {
                tail.Next = nouNode;
                tail = nouNode;
            } else
            {
                Node node;
                node = head;
                for (int i = 1; i < index; i++)
                    node = node.Next;

                nouNode.Next = node.Next;
                node.Next = nouNode;
            }

            nElem++;
        }
        public bool Remove(T item)
        {
            if (this.IsReadOnly) throw new NotSupportedException();

            bool eliminar = false;
            Node nodeActual = this.head;
            Node nodeAnterior = null;
            bool trobat = false;


            //buscar la posció de l'element
            int pos = 0;
            while (pos < Count && !eliminar)
            {
                if (nodeActual.Data.Equals(item))
                {
                    eliminar = true;
                } else
                {
                    nodeAnterior = nodeActual;
                    nodeActual = nodeActual.Next;
                    pos++;
                }
            }

            if (eliminar)
            {
                if (Count==1)
                {
                    this.head = null;
                    this.tail = null;
                }
                else if (pos==0)
                {
                    this.head = this.head.Next;
                } 
                else if (pos == Count - 1)
                {
                    nodeAnterior.Next = null;
                    tail = nodeAnterior;
                } 
                else
                {
                    nodeAnterior.Next = nodeActual.Next;
                }

                nElem--;
            }

            return eliminar;
        }
        public void RemoveAt(int index)
        {
            if (this.IsReadOnly) throw new NotSupportedException();
            if (index >= nElem || index < 0) throw new IndexOutOfRangeException("POSICIÓ NO VÀLIDA A LA LLISTA");

            Node nodeActual = this.head;
            Node nodeAnterior = null;
            for (int i = 1; i <= index; i++)
            {
                nodeAnterior = nodeActual;
                nodeActual = nodeActual.Next;
            }

            if (Count == 0)
            {
                Clear();
            }
            else if (index == 0)
            {
                this.head = this.head.Next;
            }
            else if (index == Count - 1)
            {
                nodeAnterior.Next = null;
                tail = nodeAnterior;
            }
            else
            {
                nodeAnterior.Next = nodeActual.Next;
            }

            nElem--;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }
}
