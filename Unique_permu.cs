using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class unique_permu
    {
        List<List<int>> finres = new List<List<int>>();
        List<int> new_list = new List<int>();
        Dictionary<int, int> hmap = new Dictionary<int, int>();
        public List<List<int>> All_permu(List<int> A)
        {

            for (int i = 0; i < A.Count; i++)
            {
                if (hmap.ContainsKey(A[i]))
                    hmap[A[i]]++;
                else
                    hmap.Add(A[i], 1);
            }

            find_permu(A);

            return finres;

        }

        public void find_permu(List<int> AA)
        {
            int freq = hmap.Sum(x => x.Value);
            if (freq == 0)
            {
                finres.Add(new List<int>(new_list));

            }

            List<int> keys = hmap.Keys.ToList();

            foreach (int key in keys)
            {

                if (hmap[key] > 0)
                {
                    new_list.Add(key);
                    hmap[key]--;

                    find_permu(AA);

                    new_list.RemoveAt(new_list.Count - 1);
                    hmap[key]++;
                }


            }


        }


    }
}
