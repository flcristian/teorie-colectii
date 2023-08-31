using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace teorie_colectii.colectii.entry
{
    public class Entry<K, V> : IComparable<Entry<K, V>> where K : IComparable<K>
    {
        private K _key;
        private V _value;

        // Constructors

        public Entry(K key, V value)
        {
            _key = key;
            _value = value;
        }

        #region ACCESSORS

        public K GetKey() { return _key; }

        public V GetValue() { return _value; }

        public void SetKey(K key) { _key = key; }

        public void SetValue(V value) { _value = value; }

        #endregion

        #region METHODS
        public int CompareTo(Entry<K, V>? other)
        {
            return other._key.CompareTo(_key);
        }

        #endregion
    }
}