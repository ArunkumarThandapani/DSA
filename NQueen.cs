using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class NQueen
    {
        int[][] list;
        public void calculate_Queen(int N,int i)
        {
            List<int> cur= new List<int>();
            if (i==N)
            {
                for (int uu=0;uu<N;uu++)
                {
                    Console.WriteLine( string.Join("",list[uu]));
                }
            }

            for(int j=0;j<N;j++)
            {                
                
                if (ischeck(i,j,N))
                {
                    list[i][j] = 1;
                    calculate_Queen(N,i+1);
                    list[i][j] = 0;
                }
            }
        }
        public NQueen(int N)
        {
            list = new int[N][];
            for (int i=0;i<N;i++)
            {
                list[i] = new int[N];
            }
            calculate_Queen(N,0);
        }
        public bool ischeck(int r,int c,int N)
        {
            for (int ii=0;ii<r;ii++)
            {
                if (list[ii][c] == 1) return false;

            }
            int i = r - 1;int j = c + 1;
            while (i>=0 && j < N)
            {
                if (list[i][j] == 1) return false;
                i--;
                j++;
            }
             i = r - 1;  j = c - 1;
            while (i >=0 && j >= 0)
            {
                if (list[i][j] == 1) return false;
                i--;
                j--;
            }
            return true;
        }
    }
}
