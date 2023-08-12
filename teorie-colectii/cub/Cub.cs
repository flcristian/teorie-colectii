using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.cub
{
    public class Cub : IComparable<Cub>
    {
        private int _id;
        private int _length;

        // Constructors

        public Cub(int id, int length)
        {
            _id = id;
            _length = length;
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
        
        public int Length
        {
            get { return _length; }
            set
            {
                _length = value;
            }
        }

        // Methods

        public override bool Equals(object? obj)
        {
            return (obj as Cub)._id == _id && (obj as Cub)._length == _length;
        }

        public override string ToString()
        {
            return $"Id - Length : {_id} - {_length}\n";
        }

        public int CompareTo(Cub? other)
        {
            if (_length > other._length)
            {
                return 1;
            }
            else if (other._length == _length)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
