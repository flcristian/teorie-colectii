using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.colectii.coada
{
    public interface ICoada<T> where T : IComparable<T>
    {
        Node<T> Iterator();

        void Show();
    }
}
