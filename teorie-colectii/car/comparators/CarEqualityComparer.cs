using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teorie_colectii.car.model;

namespace teorie_colectii.car.comparators
{
    public class CarEqualityComparer : IEqualityComparer<Car>
    {
        public bool Equals(Car? car1, Car? car2)
        {
            return car1.Equals(car2);
        }

        public int GetHashCode(Car car)
        {
            return (int)Math.Pow(car.GetYear(), car.GetId());
        }
    }
}
