using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class fibinocci
    {
        public int FIb_no;
        public int cnt;
        public List<int> num_ints= new List<int>();
        public List< List<int>> List_list = new List<List<int>>();
        public int fibadd;

        public int DP(int[] Dp_arr, int N,int S,int lstcnt,int no_lst)
        {
            if (N <= 0) {
                return Dp_arr[0] = 0; 
                
            }

            cnt++;
            fibadd += N;
            num_ints.Add(N);
            if (N == 1)
            {
                return Dp_arr[1] = 1;
            }


            if (fibadd== lstcnt & num_ints.Count== no_lst)
            {
                List_list.Add(num_ints);
            }




            if (Dp_arr[N] == -1)
            {

                int fibcnt = 0;
                for (int yy=S;yy>=1;yy--)
                {
                    if ((N - yy) < 0) return Dp_arr[0];
                    Dp_arr[N - yy] = DP(Dp_arr, N - yy,S, lstcnt, no_lst);
                    fibcnt += Dp_arr[N - yy];
                }
                //Dp_arr[N - 1] = DP(Dp_arr, N - 1);
                //Dp_arr[N - 2] = DP(Dp_arr, N - 2);
                //return Dp_arr[N] = (Dp_arr[N - 1] + Dp_arr[N - 2]);
                return Dp_arr[N] = fibcnt;
            }
            else
            {
                return Dp_arr[N];
            }
            cnt--;
            fibadd -= N;
            num_ints.RemoveAt(num_ints.Count - 1);  

        }


    }
}
