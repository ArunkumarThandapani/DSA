using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Listcompare : IEqualityComparer<List<int>>
    {
        public bool Equals(List<int> x, List<int> y)
        {
            if (x == null || y == null) return false;


            return x.SequenceEqual(y);
        }

        public int GetHashCode(List<int> obj)
        {
            int hash = 0;

            foreach (int x in obj)
            {
                hash += x.GetHashCode();
            }

            return hash;
        }
    }
}
