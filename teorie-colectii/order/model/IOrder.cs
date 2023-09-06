using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.order.model
{
    public interface IOrder
    {
        Order Id(int id);

        Order CarId(int id);

        Order PersonId(int id);

        public static Order BuildOrder()
        {
            return new Order();
        }
    }
}
