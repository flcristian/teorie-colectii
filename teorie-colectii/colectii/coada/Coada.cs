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
