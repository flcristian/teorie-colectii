using System.Collections.Generic;
using teorie_colectii.person.model;

namespace teorie_colectii.person.comparators
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.GetName().CompareTo(y.GetName());
        }
    }
}
