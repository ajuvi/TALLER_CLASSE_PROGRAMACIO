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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
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
