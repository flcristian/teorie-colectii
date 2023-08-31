using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.car.model
{
    public interface ICar
    {
        Car Make(String make);

        Car Model(String model);

        Car Color(String color);

        Car Year(Int32 year);

        public static Car BuildCar()
        {
            return new Car();
        }
    }
}
