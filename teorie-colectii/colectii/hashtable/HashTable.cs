using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public Boolean ContainsKey(K key)
        {
            if(Get(key) == null)
            {
                return false;
            }
            return true;
        }

        public Boolean ContainsValue(V value)
        {
            for(int i = 0; i < _entries.Length; i++)
            {
                Node<Entry<K, V>> it = _entries[i].Iterator();

                while(it != null)
                {
                    if (it.Data.GetValue().Equals(value))
                    {
                        return true;
                    }
                    it = it.Next;
                }
            }
            return false;
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

        public Boolean IsEmpty()
        {
            for(int i = 0;i < _entries.Length; i++)
            {
                if (_entries[i].Iterator() != null)
                {
                    return false;
                }
            }
            return true;
        }

        public ILista<K> KeyList()
        {
            ILista<K> list = new Lista<K>();

            for (int i = 0; i < _entries.Length; i++)
            {
                Node<Entry<K, V>> it = _entries[i].Iterator();

                while(it != null)
                {
                    list.Add(it.Data.GetKey());
                    it = it.Next;
                }
            }

            return list;
        }

        public void Put(K key, V value)
        {
            _entries[HashKey(key)].Add(new Entry<K, V>(key, value));
        }

        public void Remove(K key)
        {
            int index = HashKey(key);
            Node<Entry<K, V>> it = _entries[index].Iterator();

            int i = 0;
            while(it != null)
            {
                if (it.Data.GetKey().Equals(key))
                {
                    _entries[index].Remove(i);
                    return;
                }
                it = it.Next;
                i++;
            }
        }

        public Int32 Size()
        {
            return _entries.Length;
        }

        public ILista<V> Values()
        {
            ILista<V> values = new Lista<V>();

            for(int i = 0; i < _entries.Length; i++)
            {
                Node<Entry<K, V>> it = _entries[i].Iterator();

                while(it != null)
                {
                    values.Add(it.Data.GetValue());
                    it = it.Next;
                }
            }

            return values;
        }

        public Int32 HashKey(K key)
        {
            return key.ToString().Length % this._entries.Length;

        }
    }
}
