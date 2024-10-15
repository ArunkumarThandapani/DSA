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
        private List<List<int>> B=new List<List<int>>();

        public Graph()
        {
            A = 5;

            List<int> list = new List<int>();
            for (int i = 0; i <= A; i++)
            {
                list.Add(i);
                B.Add(new List<int>());
                list.Remove(i);
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
            int[] level = new int[A+1];
            level[ss] = 0;
            int[] parent = new int[A+1];
            parent[ss] = -1;
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
                    int cv=B[indx][ii];
                    if (bools[cv] == false)
                    {
                        bools[cv] = true;
                        //if (ee == cv) return 1;
                        Qls.Enqueue((int)cv);
                        parent[cv] = indx;
                        level[cv] = level[indx]+1;
                    }
                }

            }
            return 0;
        }
        public int BFS_vis(int start,int dest)
        {
            List<bool> visit= new List<bool>();
            for (int ii=0;ii<=A;ii++)
            {
                visit.Add(false);
            }

            Queue<int> Q = new Queue<int>();
            Q.Enqueue(start);
            visit[start] = true;
            while (Q.Count > 0)
            {
                int pos = Q.Peek();
                Q.Dequeue();
                for (int uu = 0; uu < B[pos].Count;uu++)
                {
                    visit[B[pos][uu]] = true;
                    if (dest == B[pos][uu]) return 1;
                    Q.Enqueue((int)B[pos][uu]);
                    
                }

            }

            return 0;
        }

        public bool DFS(int start,int des)
        {
            bool[]visited = new bool[A+1];
            int[]level = new int[A+1];
            int[]parent= new int[A+1];
            level[0] = 0;
            parent[0] = -1;

            Stack<int> stack = new Stack<int>();
            stack.Push(start);
             while (stack.Count > 0)
            {
                int pos = stack.Peek();
                if (visited[pos])
                {
                    stack.Pop();

                }
                else
                {
                    
                    for (int uu = 0; uu < B[pos].Count; uu++)
                    {
                        int cv = B[pos][uu];
                        if (visited[cv] == false)
                        {                            
                            visited[cv] = true;
                            stack.Push(cv);
                            level[cv] = level[pos] + 1;
                            parent[cv] = pos;
                        }

                    }
                    visited[pos] = true;
                }
            }

             return visited[des];
        }

    }
}
