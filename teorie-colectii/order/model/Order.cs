using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.order.model
{
    public class Order : IComparable<Order>, IOrder
    {
        private int _id;
        private int _carId;
        private int _personId;

        public Order(int id, int carId, int personId)
        {
            _id = id;
            _carId = carId;
            _personId = personId;
        }

        public Order()
        {
            _id = -1;
            _carId = -1;
            _personId = -1;
        }

        #region ACCESSORS

        public int GetId() { return _id; }

        public int GetCarId() { return _carId; }

        public int GetPersonId() { return _personId; }

        public void SetId(int id) { _id = id; }

        public void SetCarId(int carId) { _carId = carId; }
        
        public void SetPersonid(int personId) { _personId = personId; }

        #endregion

        #region BUILDER

        public Order Id(int id)
        {
            _id = id;
            return this;
        }

        public Order CarId(int id)
        {
            _carId = id;
            return this;
        }

        public Order PersonId(int id)
        {
            _personId = id;
            return this;
        }

        #endregion

        // Methods

        public override bool Equals(object? obj)
        {
            Order order = obj as Order;
            return order._id == _id && order._carId == _carId && order._personId == _personId;
        }

        public override string ToString()
        {
            String desc = "";
            desc += $"Id : {_id}\n";
            desc += $"Car Id : {_carId}\n";
            desc += $"Person Id : {_personId}\n";
            return desc;
        }

        public int CompareTo(Order? order)
        {
            if(_personId > order._personId)
            {
                return 1;
            }
            else if(_personId < order._personId)
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
