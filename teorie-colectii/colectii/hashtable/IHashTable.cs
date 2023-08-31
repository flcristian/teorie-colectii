using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teorie_colectii.colectii.entry;
using teorie_colectii.colectii.lista;

namespace teorie_colectii.colectii.hashtable
{
    public interface IHashTable<K,V> where K : IComparable<K> where V : IComparable<V>
    {
        ILista<K> KeyList();

        ILista<V> Values();

        ILista<Entry<K, V>> EntryList();

        void Put(K key, V value);

        V Get(K key);

        void Remove(K key);

        Boolean ContainsKey(K key);

        Boolean ContainsValue(V value);

        Int32 Size();

        Boolean IsEmpty();
    }
}
