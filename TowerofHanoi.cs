using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TowerofHanoi
    {
        public void calculate(int n, string src, string trg, string aux)
        {
            if (n == 0) return;

            calculate(n - 1, src, aux, trg);

            Console.WriteLine("Move disk " + n + " from rod "
                                      + src + " to rod " + trg);

            calculate(n - 1, aux, trg, src);
        }

        public TowerofHanoi()
        {
            int N = 3;

            calculate(N, "a", "c", "b");

            return;
        }

    }
}
