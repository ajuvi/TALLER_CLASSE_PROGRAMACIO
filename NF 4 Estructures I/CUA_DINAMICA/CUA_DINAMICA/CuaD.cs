using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUA_DINAMICA
{
    public class CuaD<T>:IEnumerable<T>
    {
        private Node head;
        private Node tail;
        private int nElem;

        public CuaD()
        {
            head = null;
            tail = null;
            nElem = 0;
        }
        public CuaD(IEnumerable<T> items)
        {
            nElem = 0;
            foreach (T item in items)
            {
                Enqueue(item);
            }
        }
        public int Count
        {
            get { return this.nElem; }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
        public bool IsEmpty
        {
            get { return Count == 0; }
        }
        
        public void Clear()
        {
            if (this.IsReadOnly) throw new NotSupportedException("LA CUA ÉS NOMÉS DE LECTURA");

            this.head = null;
            this.tail = null;
            this.nElem = 0;
        }

        public void Enqueue(T item)
        {
            if (this.IsReadOnly) throw new NotSupportedException("LA CUA ÉS NOMÉS DE LECTURA");

            Node nouNode = new Node(item);

            if (this.IsEmpty)
            {
                head = nouNode;
                tail = nouNode;
                nElem = 1;
            }
            else
            {
                //afegir el node al final de la llista
                tail.Next = nouNode;
                tail = nouNode;
                nElem++;
            }
        }

        public T Dequeue()
        {
            if (this.IsReadOnly) throw new NotSupportedException("LA CUA ÉS NOMÉS DE LECTURA");
            if (this.IsEmpty) throw new InvalidOperationException("LA CUA ESTÀ BUIDA.");
            
            T item = head.Data;
            if (nElem == 1)
            {
                tail = null;
                head = null;
            } else
                head = head.Next;

            nElem--;

            return item;
        }

        //És exactament el mateix mètode que el remove de la TaulaLlista
        public bool Leave(T item)
        {
            if (this.IsReadOnly) throw new NotSupportedException();

            bool trobat = false;
            Node nodeActual = this.head;
            Node nodeAnterior = null;

            //buscar la posció de l'element
            int pos = 0;
            while (pos < Count && !trobat)
            {
                if (nodeActual.Data.Equals(item))
                {
                    trobat = true;
                }
                else
                {
                    nodeAnterior = nodeActual;
                    nodeActual = nodeActual.Next;
                    pos++;
                }
            }

            if (trobat)
            {
                if (Count == 1)
                {
                    this.head = null;
                    this.tail = null;
                }
                else if (pos == 0)
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

            return trobat;
        }

        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("LA CUA ESTÀ BUIDA.");

            return head.Data;
        }
        public bool TryPeek(out T item)
        {
            if (IsEmpty) item = default;
            else item = head.Data;
            return !IsEmpty;
        }

        public int IndexOf(T item)
        {
            int pos = 0;
            bool trobat = false;
            Node node = head;
            while (node != null && !trobat)
            {
                if (node.Data.Equals(item))
                {
                    trobat = true;
                }
                else
                {
                    pos++;
                    node = node.Next;
                }
            }

            if (!trobat) pos = -1;

            return pos;
        }
        public bool Contains(T item)
        {
            return this.IndexOf(item) >= 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node nodeActual = head;

            for (int i = 0; i < Count; i++)
            {
                yield return nodeActual.Data;
                nodeActual = nodeActual.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("[");
            Node actual = head;
            while (actual != null)
            {
                sb.Append(actual.Data).Append(',');
                actual = actual.Next;
            }

            if(!IsEmpty) sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool iguals = true;
            CuaD<T> cua2;
            if (obj == null) iguals = false;
            else if(!(obj is CuaD<T>)) iguals = false;
            else
            {
                cua2 = (CuaD<T>)obj;
                if (this.Count != cua2.Count) iguals = false;

                Node actual = this.head;
                Node actual2 = cua2.head;

                while(iguals && actual != null)
                {
                    if (!actual.Data.Equals(actual2.Data))
                    {
                        iguals = false;
                    } else
                    {
                        actual = actual.Next;
                        actual2 = actual2.Next;
                    }
                }
            }

            return iguals;
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
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
        }


    }
}
