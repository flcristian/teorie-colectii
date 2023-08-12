using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.colectii.lista
{
    public class Lista<T> : ILista<T> where T : IComparable<T>
    {
        private Node<T> _head;

        public Node<T> Iterator()
        {
            return _head;
        }

        public void Show()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            string desc = "";

            Node<T> it = Iterator();
            while(it != null)
            {
                desc += it + "\n";
                it = it.Next;
            }

            return desc;
        }

        public void AddStart(T data)
        {
            if (_head == null)
            {
                _head = new Node<T>(data, null);
            }
            else
            {
                Node<T> node = new Node<T>(data, _head);
                _head = node;
            }

        }

        public void Add(T data)
        {
            Node<T> toAdd = new Node<T>(data, null);

            if (_head == null)
            {
                _head = toAdd;
            }
            else
            {
                Node<T> node = _head;

                while(node.Next != null)
                {
                    node = node.Next;
                }

                node.Next = toAdd;
            }
        }

        public void Add(T data, int index)
        {
            if(index == 0)
            {
                Node<T> node = new Node<T>(data, _head);
                _head = node;
            }
            else
            {
                Node<T> node = _head;

                while (index > 1 && node.Next != null)
                {
                    node = node.Next;
                    index--;
                }

                Node<T> toAdd = new Node<T>(data, node.Next);
                node.Next = toAdd;
            }
        }

        public void RemoveStart()
        {
            if(_head != null)
            {
                _head = _head.Next;
            }
        }

        public void Remove(int index)
        {
            if(_head != null)
            {
                if(index == 0)
                {
                    _head = _head.Next;
                }
                else
                {
                    Node<T> node = _head;

                    while (index > 1 && node.Next != null)
                    {
                        node = node.Next;
                        index--;
                    }

                    if (node.Next != null)
                    {
                        node.Next = node.Next.Next;
                    }
                }         
            }
        }

        public int IndexOf(T data)
        {
            Node<T> node = _head;

            int index = 0;
            while(node != null)
            {
                if(node.Data.Equals(data))
                {
                    return index;
                }
                index++;
                node = node.Next;
            }
            return -1;
        }

        public T ElementAt(int index)
        {
            Node<T> node = _head;

            while(index > 0 && node != null)
            {
                node = node.Next;
                index--;
            }

            if(node != null)
            {
                return node.Data;
            }
            return default(T);
        }

        public int Count()
        {
            int count = 0;

            Node<T> node = _head;

            while (node != null)
            {
                count++;
                node = node.Next;
            }

            return count;
        }

        // Sorting

        private void SwapWithNext(int index)
        {
            Node<T> node = _head;

            if(_head != null && _head.Next != null)
            {
                while (index > 0 && node.Next != null)
                {
                    node = node.Next;
                    index--;
                }

                T aux = node.Data;
                node.Data = node.Next.Data;
                node.Next.Data = aux;
            }
        }

        public void SortAscending()
        {
            bool flag = true;
            int i = 0;
            while(flag && i < Count())
            {
                flag = false;
                for(int j = Count() - 1; j > i; j--)
                {
                    if(ElementAt(j).CompareTo(ElementAt(j - 1)) == -1)
                    {
                        SwapWithNext(j - 1);
                        flag = true;
                    }
                }
                i++;
            }
        }

        public void SortDescending()
        {
            bool flag = true;
            int i = 0;
            while (flag && i < Count())
            {
                flag = false;
                for (int j = Count() - 1; j > i; j--)
                {
                    if (ElementAt(j).CompareTo(ElementAt(j - 1)) == 1)
                    {
                        SwapWithNext(j - 1);
                        flag = true;
                    }
                }
                i++;
            }
        }
    }
}
