using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    internal class Sudoku
    {
        List<List<int>> sudoku = new List<List<int>>() { new List<int> { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
            new List<int> { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            new List<int> { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
            new List<int> { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            new List<int> { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            new List<int> { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            new List<int> { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
            new List<int> { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
            new List<int> { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
        };

        public void solver( int x)
        {
            if (x == 81)
            {
                for (int i = 0; i < sudoku.Count; i++)
                {
                    string tt = string.Join(",", sudoku[i].ToArray());
                    Console.WriteLine(tt);
                    
                }
                return;
            }

            int r = x / 9; int c = x % 9;
            if (sudoku[r][c] != 0)
            {
                solver( x + 1);
            }
            else
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (isvalid(sudoku, r, c, i))
                    {
                        sudoku[r][c] = i;
                        solver( x + 1);
                        sudoku[r][c] = 0;
                    }
                }
            }
        }
        public bool isvalid(List<List<int>> sudoku, int r, int c, int d)
        {
            for (int i = 0; i < 9; i++)
            {
                if (sudoku[r][i] == d) { return false; }
                if (sudoku[i][c] == d) { return false; }
            }
            int rr = r - r % 3;
            int cc = c - c % 3;

            for (int x = rr; x < rr + 3; x++)
            {
                for (int y = cc; y < cc + 3; y++)
                {
                    if (sudoku[x][y] == d) { return false; }
                }
            }
            return true;
        }
    }
}
