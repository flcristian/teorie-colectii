using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.colectii.coada
{
    public class Coada<T> : ICoada<T> where T : IComparable<T>
    {
        private Node<T> _head;

        public void Push(T data)
        {
            if(_head == null)
            {
                Node<T> node = new Node<T>(data, _head);
                _head = node;
            }
            else
            {
                Node<T> node = _head;
                while(node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = new Node<T>(data, null);
            }
        }

        public void Pop()
        {
            if (_head != null)
            {
                _head = _head.Next;
            }
        }

        public T Peek()
        {
            return _head.Data;
        }

        public bool IsEmpty()
        {
            if(_head == null)
            {
                return true;
            }
            return false;
        }

        public Node<T> Iterator()
        {
            return _head; ;
        }

        public override string ToString()
        {
            string desc = "";

            Node<T> it = Iterator();
            while (it != null)
            {
                desc += it;
                it = it.Next;
            }

            return desc;
        }

        public void Show()
        {
            Console.WriteLine(this);
        }
    }
}
