using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.person.model
{
    public class Person : IComparable<Person>, IPerson
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

        public Person()
        {
            _id = -1;
            _age = 0;
            _name = "none";
            _email = "none";
        }

        #region ACCESSORS

        public int GetId() { return _id; }

        public int GetAge() { return _age; }

        public String GetName() { return _name; }

        public String GetEmail() { return _email; }

        public void SetId(int id) { _id = id; }

        public void SetAge(int age) { _age = age; }

        public void SetName(String name) { _name = name; }

        public void SetEmail(String email) { _email = email; }

        #endregion

        #region BUILDER

        public Person Id(int id)
        {
            _id = id;
            return this;
        }

        public Person Age(int age)
        {
            _age = age;
            return this;
        }
        
        public Person Name(String name)
        {
            _name = name;
            return this;
        }

        public Person Email(String email)
        {
            _email = email;
            return this;
        }

        #endregion

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
