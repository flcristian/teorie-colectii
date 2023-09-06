using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.person.model
{
    public interface IPerson
    {
        Person Id(int id);

        Person Age(int age);

        Person Name(String name);

        Person Email(String email);

        public static Person BuildPerson()
        {
            return new Person();
        }
    }
}
