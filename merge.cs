using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class merge
    {
        public void merging(int[] intarr)
        {
            int N = intarr.Length;
            mergesort(0, N - 1, intarr);

        }
        public void mergesort(int st, int ed, int[] intarr)
        {
            if (ed == st) return;
            int mid = (st + ed) / 2;

            mergesort(st, mid, intarr);
            mergesort(mid + 1, ed, intarr);
            merge_arr(intarr, st, mid, ed);

        }
        public void merge_arr(int[] intarr, int s, int m, int e)
        {
            int i = s;
            int j = m + 1;
            int k = 0;
            int[] newarr = new int[e - s + 1];

            while (i <= m && j <= e)
            {
                if (intarr[i] < intarr[j])
                {
                    newarr[k] = intarr[i];
                    i++; k++;
                }
                else
                {
                    newarr[k] = intarr[j];
                    j++; k++;
                }
            }
            while (i <= m)
            {
                newarr[k] = intarr[i];
                i++; k++;
            }
            while (j <= e)
            {
                newarr[k] = intarr[j];
                j++; k++;
            }

            int tt = 0;
            for (int x = s; x <= e; x++)
            {
                intarr[x] = newarr[tt];
                tt++;
            }
        }
    }
}
