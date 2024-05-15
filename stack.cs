using System;
using System.Collections.Generic;
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

    }
}
