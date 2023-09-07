using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.car.model
{
    public class Car: IComparable<Car>
    {
        private int _id;
        private String _make;
        private String _model;
        private String _color;
        private int _year;

        // Constructors

        public Car(int id, String make, String model, String color, int year)
        {
            _id = id;
            _make = make;
            _model = model;
            _color = color;
            _year = year;
        }

        public Car()
        {
            _id = -1;
            _make = "default";
            _model = "default";
            _color = "default";
            _year = 2023;
        }

        #region ACCESSORS

        public int GetId() { return _id; }

        public String GetMake() { return _make; }

        public String GetModel() { return _model; }

        public String GetColor() { return _color; }

        public Int32 GetYear() { return _year; }

        public void SetId(int id) { _id = id; }

        public void SetMake(String make) { _make = make; }

        public void SetModel(String model) { _model = model; }

        public void SetColor(String color) { _color = color; }

        public void SetYear(Int32 year) { _year = year; }

        #endregion

        #region BUILDER

        public Car Id(int id)
        {
            _id = id;
            return this;
        }

        public Car Make(String make)
        {
            _make = make;
            return this;
        }

        public Car Model(String model)
        {
            _model = model;
            return this;
        }

        public Car Color(String color)
        {
            _color = color;
            return this;
        }

        public Car Year(Int32 year)
        {
            _year = year;
            return this;
        }

        #endregion

        // Methods

        public override string ToString()
        {
            string desc = "";

            desc += $"Id : {_id}\n";
            desc += $"Make : {_make}\n";
            desc += $"Model : {_model}\n";
            desc += $"Color : {_color}\n";
            desc += $"Year : {_year}\n";

            return desc;
        }

        public override bool Equals(object? obj)
        {
            Car car = obj as Car;
            return car._id == _id && car._make.Equals(_make) && car._model.Equals(_model) && car._color.Equals(_color) && car._year == _year;
        }

        public int CompareTo(Car? other)
        {

            if (_year > other._year)
            {
                return 1;
            }
            else if (_year < other._year)
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
