using System.Collections.Generic;
using teorie_colectii.person.model;

namespace teorie_colectii.person.comparators
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.Length < y.Name.Length)
            {
                return 1;
            }
            else if (x.Name.Length > y.Name.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
