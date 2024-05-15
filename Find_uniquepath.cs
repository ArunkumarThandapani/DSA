using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Find_uniquepath
    {
        int fincnt = 0;
        int maxcnt = 0;
        int stcnt = 0;
        int negcnt = 0;
        public int solve(List<List<int>> A)
        {

            Dictionary<KeyValuePair<int, int>, bool> fin_path = new Dictionary<KeyValuePair<int, int>, bool>();
            int R = A.Count();
            int C = A[0].Count();


            int i = 0;
            int j = 0;
            find_path(A, R, C, i, j, ref fin_path);

            return fincnt;

        }
        public void find_path(List<List<int>> all_lst, int R, int C, int i, int j, ref Dictionary<KeyValuePair<int, int>, bool> fin_path)
        {




            if ((i >= 0 & i < R) & (j >= 0 & j < C))
            {
                //if (fin_path[new KeyValuePair<int, int>(i, j)]) return;

                if (all_lst[i][j] == 2)
                {
                    //if (fin_path.Count > maxcnt)
                    //{
                    //    fincnt = 1;
                    //    maxcnt = fin_path.Count;
                    //}
                    //else 
                    if (negcnt == 1)
                    {
                        fincnt++;
                    }
                    return;
                }
                


                if (!fin_path.ContainsKey(new KeyValuePair<int, int>(i, j)))
                    fin_path.Add(new KeyValuePair<int, int>(i, j), true);

                if (fin_path[new KeyValuePair<int, int>(i, j)] & all_lst[i][j] == -1)
                {
                    negcnt++;
                    return;
                }
                else if (!fin_path[new KeyValuePair<int, int>(i, j)] & all_lst[i][j] == -1)
                {
                    negcnt--;
                    return;
                }



                

                //if (all_lst[i][j] == 0 || all_lst[i][j] == 1)
                //{

                    //fin_path[new KeyValuePair<int, int>(i, j)]=true;
                    find_path(all_lst, R, C, i, j + 1, ref fin_path);
                    find_path(all_lst, R, C, i + 1, j, ref fin_path);
                    find_path(all_lst, R, C, i - 1, j, ref fin_path);
                    find_path(all_lst, R, C, i, j - 1, ref fin_path);
                    fin_path[new KeyValuePair<int, int>(i, j)]=false;

                    if (fin_path.ContainsKey(new KeyValuePair<int, int>(i, j)))
                        fin_path.Remove(new KeyValuePair<int, int>(i, j));
                //}


            }

        }

    }
}
