using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.colectii
{
    public class Node<T> : IComparable<Node<T>> where T : IComparable<T>
    {
        private T _data;

        private Node<T> _next;

        // Constructors

        public Node(T data, Node<T> next)
        {
            _data = data;
            _next = next;
        }

        // Accessors

        public T Data
        {
            get { return _data; }
            set
            {
                _data = value;
            }
        }

        public Node<T> Next
        {
            get { return _next; }
            set
            {
                _next = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "";

            desc += $"Data : {_data}";

            return desc;
        }

        public override bool Equals(object? obj)
        {
            return (obj as Node<T>)._data.Equals(_data) && (obj as Node<T>)._next.Equals(_next);
        }

        public int CompareTo(Node<T>? other)
        {
            return _data.CompareTo(other._data);
        }
    }
}
