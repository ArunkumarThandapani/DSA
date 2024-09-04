using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class NStairs
    {
        public NStairs(int N_STAIR) { N = N_STAIR; }
        readonly  int N ;
        int[] dp;
        public int Reach_Nstairs_count(int NN)
        {

            
            if (NN==N)
            {
                dp = new int[N+1];
                for (int uu = 0; uu < N; uu++)
                {
                    dp[uu] = -1;
                }
            }
            if (NN <= 1) { 
                dp[NN] = 1; 
                return dp[NN]; 
            }

            dp[NN] = (dp[NN-1]==-1 ? Reach_Nstairs_count(NN - 1) : dp[NN-1]) + (dp[NN-2] ==-1 ?( Reach_Nstairs_count(NN - 2)) : dp[NN-2]);
            return dp[NN];


        }

    }

    public class DiceNways
    {
        int N ;
        int[] dp;

        public DiceNways(int N)
        {
            N = N;
            dp = new int[N + 1];
            for (int uu = 0; uu <= N; uu++)
            { dp[uu] = -1; dp[0] = 1; }
        }
        public int calc_recursive(int NN)
        {
            
            if (dp[NN] != -1) return dp[NN];

            int val = 0;

            for (int i=1;i<= NN;i++)
            {
                if (NN-i>=0)
                val = val + calc_recursive(NN - i);
            }

            return dp[NN]= val;
        }
        public int calc_dynamic_Nspace(int NN)
        {

            if (dp[NN] != -1) return dp[NN];

            int val = 0;

            for (int i = 1; i <= NN; i++)
            {
                for (int j = 1; i>=j && j <= 6; j++)
                {
                    //if (i - j >= 0)
                        dp[i] = dp[i] + dp[i - j];
                }
            }

            return dp[NN];
        }
        public int calc_dynamic_space1(int NN)
        {

            if (dp[NN] != -1) return dp[NN];

            int val = 0;

            for (int i = 1; i <= NN; i++)
            {
                for (int j = 1;  i>=j && j <= 6; j++)
                {
                    //if (i - j >= 0)
                        val +=  dp[(i - j)%6];
                }
                dp[i % 6] = val;
            }

            return dp[NN];
        }
    }

    public class NoOfPairs
    {
        int N;
        int[] dp;
        public NoOfPairs(int n)
        {
            N = n;
            dp = new int[N+1];
            for (int i = 0;i <= N;i++)
            { dp[i] = -1; }
            dp[0] = 1;
            dp[1] = 1;
        }
        public int calc_Possible_Pair_count_with_arr(int NN)
        {
            
            for (int i = 2 ;i<=NN;i++)
            {
                int val = 0;
                for (int j=1; i>=j && j<=2;j++)
                {
                    if (j == 1)
                        val += dp[(i - 1)];
                    else
                        val += (i - 1) * dp[(i - 2)];
                }
                dp[i]=val;
            }
            return dp[NN];
        }
        public int calc_Possible_Pair_count_without_arr(int NN)
        {
            int a = 1;
            int b = 1;
            int c = 0;

            for (int i = 2; i <= NN; i++)
            {
                c = 0;
                for (int j = 1; i >= j && j <= 2; j++)
                {
                    if (j == 1)
                        c += b;
                    else
                        c += (i-1) * a;
                }
                a = b;
                b = c;
            }
            return c;
        }
    }


    public class Minperf_sqr
    {
        int[] DP;
        int N ;
        public Minperf_sqr(int NN) 
        {
            N = NN;
            DP = new int[N+1];
            for (int uu=0;uu<=N; uu++)
            { DP[uu] = -1; }

            DP[0] = 0;
        }
        public int calc_Perf_sqr()
        {
            int ans;
            for (int i=1;i<=N;i++)
            {
                ans = i;
                for (int j=1;j*j<=i;j++)
                {
                    ans=Math.Min(ans, 1+ DP[i-(j*j)]);
                }
                DP[i] = ans;
            }
            return DP[N];
        }
    }

    public class Maxsubseq_sum
    {
        int[] DP;

        public int calc_Max_subSeq_SUM(List<int> liss)
        {
            DP= new int[liss.Count];
            DP[0] = liss[0];
            DP[1] = Math.Max(liss[0], liss[1]);
            for (int i=2;i< liss.Count; i++)
            {
                int ans= liss[i];
                DP[i] = Math.Max(liss[i] + DP[i - 2], DP[i - 1]);
            }
            return DP[liss.Count - 1];
        }

        public int calc_Max_subSeq_SUM_Space1(List<int> liss)
        {
            
            int a = liss[0];
            int b = Math.Max(liss[0], liss[1]);
            int c = 0;
            for (int i = 2; i < liss.Count; i++)
            {

                c = Math.Max(liss[i] + a, b);
                a = b;
                b = c;
            }
            return c;
        }
    }
}
