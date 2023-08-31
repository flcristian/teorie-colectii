using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.colectii.entry
{
    public interface IEntry<K,V>
    {
        K GetKey();

        V GetValue();

        V SetValue(V value);
    }
}
