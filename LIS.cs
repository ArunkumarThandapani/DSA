using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class LIS
    {

        List<List<int>> Finlst= new List<List<int>>();
        int maxseq = 0;
        public void LIS_recursion()
        {
            
            List<int> list = new List<int>() { 3, 2, 4, 6, 3, 10, 11, 7, 9, 5 };
            List<int> seq_lst= new List<int>();
            int N = list.Count();
            lis_RECR(list, seq_lst, N, 1);

        }

        public void lis_RECR(List<int> cur,List<int> seq_lst, int N,int j)
        {

            if (j ==(N-1))
            {
                maxseq= Math.Max(maxseq, seq_lst.Count);
                Finlst.Add(seq_lst.ToList());
                return;
            }
           
            for (int uu = j; uu < N-1; uu++)
            {


            }
        }

    }
}
