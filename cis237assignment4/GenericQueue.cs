//Anthony Aernie
//CIS237 MW 6:00
//Mar 20, 2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericQueue<T> : IGenericQueue<T>
    {
        protected class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        protected Node _head;
        protected Node _tail;
        protected int _size;

        public bool IsEmpty
        {
            get
            {
                return _head == null;
            }
        }

        public int Size
        {
            get
            {
                return _size;
            }
        }

        //enqueue item into queue
        public void AddToBack(T Data)
        {
            Node oldTail = _tail;
            _tail = new Node();
            _tail.Data = Data;
            _tail.Next = null;
            _size++;
            if (_head == null)
            {
                _head = _tail;
            }
            else
            {
                oldTail.Next = _tail;
            }
        }

        //dequeue item from queue
        public T RemoveFromFront()
        {
            if (IsEmpty)
            {
                throw new Exception("list is empty");
            }
            else
            {
                T returnData = _head.Data;
                _head = _head.Next;
                _size--;
                return returnData;
            }
        }
    }
}
