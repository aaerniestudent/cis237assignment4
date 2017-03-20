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
    class GenericStack<T> : IGenericStack<T>
    {

        protected class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        
        protected Node _head;//Tail is not necessary, we only need the head
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

        //Push item on to stack
        public void AddToTop(T Data)
        {
            Node oldHead = _head;
            _head = new Node();
            _head.Data = Data;
            _head.Next = oldHead;
            _size++;            
        }

        //Pop item off of the top of the stack
        public T RemoveFromTop()
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
