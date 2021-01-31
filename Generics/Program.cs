using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("adana");
                                                            
            MyList<string> cities2 = new MyList<string>();
            cities2.Add("samsun");
        }

    }

    class MyList<T>
    {
        T[] array;
        public void Add(T item)
        {

        }
    }
}
