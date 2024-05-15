using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Dyn_Program
    {

        int finval = 0;
        int[] DP;
        public int countMinSquares(int A)
        {


            DP = new int[A + 1];
            for (int uu = 0; uu <= A; uu++)
                DP[uu] = -1;

            DP[0] = 0;
            DP[1] = 1;

            return sqrtval(A);
        }

        public int sqrtval(int A)
        {
            if (DP[A] != -1)
                return DP[A];

            Hashtable ht= new Hashtable();
            ht.Add(0, 1);
            ht.Add("Arun", "Prabu");
            

            Dictionary<int, Tuple<int,string>> ht2= new Dictionary<int, Tuple<int, string>>();
            ht2.Add(0, Tuple.Create(0,"zero"));
            
            List<Tuple<int, string, int, Dictionary<int,string>>> tup = new List<Tuple<int, string, int, Dictionary<int, string>>>();

            SortedSet<int> slist = new SortedSet<int>() { 9,8,7,6,5};
            

            var tupp = Tuple.Create(1, 2, 3, 4, "Six", Tuple.Create(7, "eight"),new KeyValuePair<int,string>(9,"nine"));

            ht.Add(ht.Count, DP[A]);

            int ans = Int32.MaxValue;


            for (int ii = 1; ii * ii <= A; ii++)
            {
                ans = Math.Min(ans, sqrtval(A - (ii * ii)));

            }
            DP[A] = ans + 1;
            return DP[A];
        }
    }
}
