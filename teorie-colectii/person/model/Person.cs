using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.person.model
{
    public class Person : IComparable<Person>
    {
        private int _id;
        private int _age;
        private String _name;
        private String _email;
        
        // Constructors

        public Person(int id, int age, String name, String email)
        {
            _id = id;
            _age = age;
            _name = name;
            _email = email;
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

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
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

        public String Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }

        // Methods

        public override string ToString()
        {
            string desc = "";

            desc += $"Id : {_id}\n";
            desc += $"Age : {_age}\n";
            desc += $"Name : {_name}\n";
            desc += $"Email : {_email}\n";

            return desc;
        }

        public override bool Equals(object? obj)
        {
            return (obj as Person)._id == _id && (obj as Person)._age == _age && (obj as Person)._name.Equals(_name) && (obj as Person)._email.Equals(_email);
        }

        public int CompareTo(Person? other)
        {
            if(_age > other._age)
            {
                return 1;
            }
            else if (_age < other._age)
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
