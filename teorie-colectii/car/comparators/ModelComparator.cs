using System.Collections.Generic;
using teorie_colectii.car.model;

namespace teorie_colectii.car.comparators
{
    public class ModelComparator : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.GetModel().CompareTo(y.GetModel());
        }
    }
}
