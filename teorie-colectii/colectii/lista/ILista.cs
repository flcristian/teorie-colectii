using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.colectii.lista
{
    public interface ILista<T> where T : IComparable<T>
    {
        void AddStart(T data);

        void Add(T data);

        void Add(T data, int index);

        void RemoveStart();

        void Remove(int index);

        int IndexOf(T data);

        T ElementAt(int index);

        void SortAscending();

        void SortDescending();

        Node<T> Iterator();

        void Show();
    }
}
