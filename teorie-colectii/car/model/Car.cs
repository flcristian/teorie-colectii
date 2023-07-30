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
        private String _name;
        private String _model;
        private String _color;
        private int _year;

        // Constructors

        public Car(int id, String name, String model, String color)
        {
            _id = id;
            _name = name;
            _model = model;
            _color = color;
        }

        // Accessors

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public String Model
        {
            get { return _model; }
            set
            {
                _model = value;
            }
        }

        public String Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "";

            desc += $"Id : {_id}\n";
            desc += $"Name : {_name}\n";
            desc += $"Model : {_model}\n";
            desc += $"Color : {_color}\n";
            desc += $"Year : {_year}\n";

            return desc;
        }

        public override bool Equals(object? obj)
        {
            return (obj as Car)._id == _id && (obj as Car)._name.Equals(_name) && (obj as Car)._model.Equals(_model) && (obj as Car)._color.Equals(_color) && (obj as Car)._year == _year;
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
