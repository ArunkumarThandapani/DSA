using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public  class stack
    {

        public string chk_string(string A)
        {
            string dd = "";
            int lenn = A.Length-1;
            Stack<char> stch = new Stack<char>();
            for (int yy = lenn; yy >= 0; yy--)
            {
                if (stch.Count()==0)
                {
                    stch.Push(A[yy]);
                    
                }
                else if (!isMatch(A[yy],stch))
                {
                    stch.Push(A[yy]);
                }
                else
                {
                    stch.Pop();
                }
            }

            while( stch.Count()>0) 
            { dd += stch.Pop(); }



            return dd == "ab" ? "a" : "B";
        }

        public bool isMatch(char ch, Stack<char> Q)
        {
            if ( (ch == '{' && Q.Peek() == '}'))
            {
                return true;
            }
            else if ( (ch == '(' && Q.Peek() == ')'))
            {
                return true;
            }
            else if ( (ch == '[' && Q.Peek() == ']'))
            {
                return true;
            }

            return false;
        }

        public int[] nxtGenerator_stk(int[] A)
        {
            Stack<int> stk = new Stack<int>();
            int N = A.Length;
            int[] ans= new int[N];
            if (N==0) return ans;
            if (N == 1) { ans[0] = -1; return ans; }
            stk.Push(A[0]);
            int element=0, next=0;
            for (int yy=1;yy<N;yy++)
            {
                next = A[yy];
                while (stk.Count > 0)
                {
                    element = stk.Pop();



                    if (element < next)
                    {
                        ans[yy - 1] = next;
                        stk.Push(next);
                    }
                    else if (element > next)
                    {
                        stk.Push(A[yy++]);
                        if (yy == N) break;
                    }
                        
                }

                stk.Push(next);
            }
            while (stk.Count == 0)
            {
                stk.Pop();
            }


            return ans;
        }

        public List<int> nextGreater(List<int> A)
        {
            List<int> ans = new List<int>();
            int N = A.Count;
            if (N == 0) return ans;
            if (N== 1) {ans.Add(-1); return ans; }
            Queue<int> nxtgen = new Queue<int>();
            nxtgen.Enqueue(A[0]);
            int element, next;
            for (int yy = 1; yy < N; yy++)
            {
                next = A[yy];
                
                if (nxtgen.Count > 0)
                {
                    
                    element = nxtgen.Dequeue();


                    if (element < next)
                    {
                        nxtgen.Enqueue(next);
                    }

                    int tmp = yy;
                    while (element > next)
                    {                        
                        if (tmp == N) break;
                        if (nxtgen.Count == 0) 
                            nxtgen.Enqueue(A[tmp]);
                        
                        next = A[tmp];
                        tmp++;

                    }
                    if (element < next) { ans.Add(next); }
                    else ans.Add(-1);

                    if (yy==N-1) ans.Add(-1);


                }

                //if (nxtgen.Count == 0)
                //    nxtgen.Push(next);
            }

            return ans;
        }

    }
}
