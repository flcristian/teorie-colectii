using System.Collections.Generic;
using teorie_colectii.car.model;

namespace teorie_colectii.car.comparators
{
    public class ModelComparator : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if(x.Model.Length < y.Model.Length)
            {
                return 1;
            } 
            else if (x.Model.Length > y.Model.Length)
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
