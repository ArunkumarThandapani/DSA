using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Graph
    {
        private int A;
        private List<List<int>> B;

        public Graph()
        {
            A = 5;

            for (int i = 0; i <= A; i++)
            {
                B.Add(new List<int>());
            }
            B[1].Add(2);
            B[1].Add(3);
            B[1].Add(4);
            B[2].Add(3);

            B[3].Add(5);

            B[4].Add(3);
            
            
            B[4].Add(5);
            

        }

        public int BFS(int ss,int ee)
        {
            List<bool> bools = new List<bool>();
            for (int i = 0;i <= A;i++)
            {
                bools.Add(false);
            }
            Queue<int> Qls = new Queue<int>();
            Qls.Enqueue(ss);

            while (Qls.Count > 0) 
            {
                int indx=Qls.Peek();
                bools[indx] = true;

                Qls.Dequeue();
                for ( int ii=0;ii<B[indx].Count;ii++)
                {
                    bools[B[indx][ii]] = true;
                    if (ee == B[indx][ii]) return 1;
                    Qls.Enqueue((int)B[indx][ii]);
                }

            }
            return 0;
        }





    }
}
