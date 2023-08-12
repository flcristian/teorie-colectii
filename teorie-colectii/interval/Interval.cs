using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie_colectii.interval
{
    public class Interval : IComparable<Interval>
    {
        int _low;
        int _high;

        // Constructors

        public Interval(int low, int high)
        {
            _low = low;
            _high = high;
        }

        // Accessors

        public int Low
        {
            get { return _low; }
            set
            {
                _low = value;
            }
        }

        public int High
        {
            get { return _high; }
            set
            {
                _high = value;
            }
        }

        // Methods
        
        public override bool Equals(object? obj)
        {
            return (obj as Interval)._low == _low && (obj as Interval)._high == _high;
        }

        public override string ToString()
        {
            return $"[{_low}, {_high}]\n";
        }

        // Checks if the intervals intersect
        public int CompareTo(Interval? other)
        {
            if(other._low > _high || other._high < _low)
            {
                return 0;
            }
            return 1;
        }

        public Interval ReuniteWith(Interval other)
        {
            int low = _low;
            if(other._low < low)
            {
                low = other._low;
            }

            int high = _high;
            if(other._high > high)
            {
                high = other._high;
            }

            return new Interval(low, high);
        }
    }
}
