using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Backtrack
    {
        
        List<List<int>> anslst=new List<List<int>>();
        List<List<int>> subset_lst = new List<List<int>>();
        public void create_lists(int N)
        {
            
            List<int> list = new List<int>();
            Console.WriteLine("List 1,2 Generation");
            generate_listswithnum(N, 3, 0, list);

            Console.WriteLine("List Generation");
            generate_lists(N, 0,false, list);

            Console.WriteLine("List Generation no Repeat");
            generate_lists(N, 0, true, list);

            Console.WriteLine("Subset Generation");
            generate_subset(N, 0, list);
            
        }
        public void generate_lists(int N,int idx,bool rept, List<int> curlst)
        {
            if (idx == N)
            {
                string tt = "[";
                curlst.All((x) =>
                {
                    tt +=  x + ",";
                    return true;
                    
                });
                tt = (tt == "") ? "" : tt.Substring(0,tt.Length-1) +"]";
                Console.WriteLine(tt);
                anslst.Add(curlst.ToList());                
                return;
            }


            for (int i = 1; i <= N; i++)
            {
               bool lstrp= curlst.Contains(i);
                if (!rept)
                {
                    curlst.Add(i);
                    generate_lists(N, idx + 1, rept, curlst);
                    curlst.Remove(i);
                }
                else if (lstrp != rept)
                {
                    curlst.Add(i);
                    generate_lists(N, idx + 1, rept, curlst);
                    curlst.Remove(i);
                }
            }
        }

        public void generate_listswithnum(int N,int NX, int idx, List<int> curlst)
        {
            if (idx == N)
            {
                string tt = "[";
                curlst.All((x) =>
                {
                    tt += x + ",";
                    return true;

                });
                tt = (tt == "") ? "" : tt.Substring(0, tt.Length - 1) + "]";
                Console.WriteLine(tt);
                anslst.Add(curlst.ToList());
                return;
            }


            for (int i = 1; i <= NX; i++)
            {                
                curlst.Add(i);
                generate_listswithnum(N,NX, idx + 1, curlst);
                curlst.Remove(i);

            }
        }

        public void generate_subset(int N, int idx, List<int> curlst)
        {
            if (idx == N)
            {
                string tt = "[";
                curlst.All((x) =>
                {
                    tt += x + ",";
                    return true;

                });
                tt =(tt=="")? "": tt.Substring(0, tt.Length - 1) + "]";
                Console.WriteLine(tt);
                subset_lst.Add(curlst.ToList());
                return;
            }


            curlst.Add(idx+1);
            generate_subset(N, idx + 1, curlst);
            curlst.Remove(idx+1);
            generate_subset(N, idx + 1, curlst);


        }

    }
}

public class Backtrack_num
{
    List<IList<int>> ans = new List<IList<int>>();

    public IList<IList<int>> Permute(int[] nums)
    {

        List<int> curlst = new List<int>();
        generate_list(nums.Length, nums, 0, curlst);

        return ans;
    }

    public void generate_list(int N, int[] nums, int idx, List<int> curlst)
    {
        if (N == idx)
        {
            ans.Add(curlst);
            return;
        }

        bool avl = curlst.Contains(nums[idx]);
        if (!avl)
        {
            curlst.Add(nums[idx]);
            generate_list(N, nums, idx + 1, curlst);
            curlst.Remove(nums[idx]);
        }

    }
}
