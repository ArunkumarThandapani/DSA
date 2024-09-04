using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Twopointer
    {
        public List<int> A = new List<int>() { -3,0,1,3,6,8,11,14,18,25};
        public List<int> B = new List<int>() { 3,5,4,7,3,6,5,4,1,2 };


        public bool addval_fnd(int findval)
        {
            int p1 = 0;
            int p2 = A.Count-1;

            while (p1 < p2)
            {
                if ((A[p1] + A[p2]) > findval) p2--;
                else if((A[p1] + A[p2]) < findval) p1++;
                else
                {
                     if((A[p1] + A[p2])==findval) return true;
                }
            }

            return false;
        }
        public bool sub_val_fnd(int findval)
        {
            int p1 = 0;
            int p2 = 1;

            while (p2 < A.Count)
            {
                int diff = A[p2] - A[p1];
                if (diff ==findval) return true;    
                if (diff <findval) p2++;
                if (diff > findval)
                {
                    p1++;
                    if (p1 == p2) p2++;
                }
            }

            return false;
        }

        public int water_trapping()
        {
            int left =0;
            int right = B.Count-1;

            int lmax = 0;
            int rmax = 0;
            int water = 0;

            while (left <= right) 
            {
                if (rmax <= lmax)
                {
                    water += Math.Max(0, rmax - B[right]);
                    rmax = Math.Max(rmax, B[right]);
                    right--;
                }
                else
                {
                    water += Math.Max(0, lmax - B[left]);
                    lmax=Math.Max(lmax, B[left]);
                    left++;
                }
            }
            return water;
        }
    }
}
