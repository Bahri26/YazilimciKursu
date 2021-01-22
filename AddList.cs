using System;
using System.Collections.Generic;
using System.Text;

namespace AddMethod
{
    class AddList<N,D>
    {
        List<N> _values;
        List<D> _days ;

        public AddList()
        {
            _values = new List<N>();
            _days = new List<D>();
        }

        public void Add(N _values,D _days)
        {
            Console.WriteLine("{0}. gün = {1}", _values, _days);
        }

        public int Count
        {
            get { return _days.Count;}
        }
    }

    
}
