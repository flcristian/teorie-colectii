using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teorie_colectii.colectii.entry;
using teorie_colectii.colectii.lista;

namespace teorie_colectii.colectii.hashtable
{

    public class HashTable<K,V> : IHashTable<K,V> where K : IComparable<K> where V : IComparable<V>
    {
        private ILista<Entry<K, V>>[] _entries;

        public HashTable(int size)
        {
            _entries = new ILista<Entry<K, V>>[size];

            for(int i = 0; i < _entries.Length; i++)
            {
                _entries[i] = new Lista<Entry<K, V>>();
            }

        }

        public override String ToString()
        {
            String desc = "";
            for(int i = 0; i < _entries.Length; i++)
            {
                Node<Entry<K, V>> it = _entries[i].Iterator();

                if(it != null)
                {
                    desc += $"=-=-=-=-=-=\nPOSITION {i}\n=-=-=-=-=-=\n";
                    while(it != null)
                    {
                        desc += "Entry :\n";
                        desc += $"Key : {it.Data.GetKey()}\n";
                        desc += $"Value : {it.Data.GetValue()}\n";

                        it = it.Next;
                    }
                }
            }
            return desc;
        }

        public bool ContainsKey(K key)
        {
            throw new NotImplementedException();
        }

        public bool ContainsValue(K key)
        {
            throw new NotImplementedException();
        }

        public ILista<Entry<K, V>> EntryList()
        {
            ILista<Entry<K, V>> list = new Lista<Entry<K, V>>();

            for(int i = 0; i < _entries.Length; i++)
            {
                Node<Entry<K, V>> it = _entries[i].Iterator();

                while(it != null)
                {
                    list.Add(it.Data);
                    it = it.Next;
                }
            }

            return list;
        }

        public V Get(K key)
        {
            Node<Entry<K, V>> it = _entries[HashKey(key)].Iterator();

            while (it != null)
            {
                if (it.Data.GetKey().Equals(key))
                {
                    return it.Data.GetValue();
                }
                it = it.Next;
            }

            return default(V);
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public ILista<K> KeyList()
        {
            throw new NotImplementedException();
        }

        public void Put(K key, V value)
        {
            _entries[HashKey(key)].Add(new Entry<K, V>(key, value));
        }

        public void Remove(K key)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }

        public ILista<V> Values()
        {
            throw new NotImplementedException();
        }

        public int HashKey(K key)
        {
            return key.ToString().Length % this._entries.Length;

        }
    }
}
