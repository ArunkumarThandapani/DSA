using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    public class BaseClass
    {
        private protected int myValue = 0;       
        static void Main(string[] args)
        {
            #region sudoko_solver

            Sudoku sudo = new Sudoku();
            sudo.solver(0);

            #endregion



            #region Backtracking
            Backtrack BT = new Backtrack();
            BT.create_lists(5);

            int[] nums =new int[3]{ 1,2,3};
            Backtrack_num BTN = new Backtrack_num();
            BTN.Permute(nums);

            #endregion


            #region towpoint

            Twopointer TP = new Twopointer();
            bool add_fnd= TP.addval_fnd(17);
            bool sub_fnd = TP.sub_val_fnd(5);
            int water=TP.water_trapping();

            #endregion

            #region tower of Hanoi

            TowerofHanoi TH = new TowerofHanoi();
            #endregion
            #region min_perf_sqr
            Minperf_sqr MInsqr = new Minperf_sqr(24);
            int ans=MInsqr.calc_Perf_sqr();
            #endregion

            #region Max_subsequence_sum
            Maxsubseq_sum max_subeq_sum= new Maxsubseq_sum();
            int ret_val=max_subeq_sum.calc_Max_subSeq_SUM(new List<int> { 9, 4, 13, 24 });
            int ret_val1 = max_subeq_sum.calc_Max_subSeq_SUM_Space1(new List<int> { 9, 4, 13, 24 });


            #endregion 

            #region NO_OF_Pair

            NoOfPairs No_Of_pair = new NoOfPairs(5);
                int pair_cnt = No_Of_pair.calc_Possible_Pair_count_with_arr(5);
                int pair_cn = No_Of_pair.calc_Possible_Pair_count_without_arr(5);

            #endregion

            #region Ndice

                DiceNways dicecnt = new DiceNways(4);
                int rec_out=dicecnt.calc_recursive(4);
                int Dyn_Nspc = dicecnt.calc_dynamic_Nspace(4);
                int Dyn_spc1 = dicecnt.calc_dynamic_space1(4);

            #endregion

            #region Nstairs

                NStairs Ns = new NStairs(4);
                int GG=Ns.Reach_Nstairs_count(4);

            #endregion


            #region Graph
            //Graph grp= new Graph();
            //int uu=grp.BFS(1, 2);

            #endregion

            #region stack

                stack stk = new stack();
                stk.chk_string("(){");

            #endregion

            #region DJIkstra
                DJI_kstra DJik = new DJI_kstra();
                int[] distance = DJik.Solve_shortpath();

            #endregion


            #region tries
                Treis treis = new Treis();
                treis.Insert("Arun");
                treis.Insert("Rahini");
                treis.Insert("Arwin");
                treis.Insert("Aarya");


                treis.search("Arwin");
                treis.search("Aary");
            #endregion


            #region Heapify
            Maxheap mxh = new Maxheap();
            List<int> list = new List<int>() { 35,33,42,10,14,19,27,44,26,31};
            mxh.MH_lst= mxh.heap(0,ref list);
            mxh.insert(100);
            mxh.removeat(0);

            minheap mnh = new minheap();
            mnh.MH_lst = mnh.heap(0, ref list);
            mnh.insert(9);            
            mnh.removeat(3);
            #endregion


            #region mergesort
            int[] intarr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                merge merg = new merge();
                merg.merging(intarr);
            #endregion

            #region Find_Unique_path
                Find_uniquepath find_up = new Find_uniquepath();
            List<List<int>> all_lsst = new List<List<int>>{
                new List<int>() { 1, 0, 0,0 },
                new List<int>() { 0, 0, 0,0 },
                new List<int>() { 0, 0, 2,-1 }
            };
            //List<List<int>> all_lsst = new List<List<int>>{
            //        new List<int>() { 0, 1 },
            //        new List<int>() { 2, 0  }
            //    };
            //find_up.solve(all_lsst);
                #endregion


            #region Unique_permu
                unique_permu un_per = new unique_permu();
                List<int> allvals = new List<int>() { 1, 2,2};
                List<List<int>> all_lst= un_per.All_permu(allvals);
            #endregion

            #region Dynamic_Programming
                Dyn_Program MQS = new Dyn_Program();
                int yxy= MQS.countMinSquares(13);
                Console.WriteLine("Enter the Value :");
                int A = Convert.ToInt32(Console.ReadLine());
                int[] dparr = new int[A + 1];
                for (int yy = 0; yy <= A; yy++)
                {
                    dparr[yy] = -1;
                }
                fibinocci fb = new fibinocci();
                int no_lst = 2;
                
                int max_ar = (int) Math.Ceiling((double)(A / no_lst)) + 1;


                fb.DP(dparr, A, max_ar, A, no_lst);            
                Console.WriteLine(dparr[A]);
            

                //int A = 5;
                int[] DP_arr = new int[A + 1];
                for (int i = 0; i <= A ; i++)
                    DP_arr[i] = -1;
                //fibinocci fb = new fibinocci();
                fb.DP(DP_arr, A,3,A, no_lst);
            #endregion


            #region Linked_list
                List<int> int_lst = new List<int>() { 1, 2, 3, 4, 5, 5 };
                LL bs = new LL();
                LL reff=bs.return_ll(int_lst);

                reff= bs.return_Fun_LL(int_lst);    


                LL rev_LL =bs.reverse_LL_base_int(reff, 3);

                bs.deleteDuplicates(reff);
                Console.WriteLine("Insert");
                reff = bs.insert_LL(9, 3);
                bs.print_all();
                Console.WriteLine("Delete");
                reff = bs.delete_LL(3);
                bs.print_all();
                reff = bs.removeNthFromEnd(reff,1);
            #endregion
        }
    }

    public class Maxheap
    {
        public List<int> MH_lst = new List<int>();
        public List<int> heap(int idx, ref List<int> Listval)
        {
            int indxval = 0;
            for (int yy = idx; yy < Listval.Count; yy++)
            {
                if (MH_lst.Count == 0)
                {
                    if (MH_lst.Count < Listval.Count)
                        MH_lst.Add(Listval[yy]);
                }
                else
                {


                    if (yy % 2 == 1)
                    {
                        if (yy - 1 == 0) indxval = 0;
                        else indxval = (yy - 1) / 2;
                    }
                    else
                    {
                        if (yy - 2 == 0) indxval = 0;
                        else indxval = (yy - 2) / 2;
                    }

                    if (indxval < 0) break;
                    if (MH_lst.Count < Listval.Count)
                        MH_lst.Add(Listval[yy]);



                    if (MH_lst[yy] >= MH_lst[indxval])
                    {
                        heapify(yy);
                        //    int tmp = MH_lst[yy];
                        //    MH_lst[yy] = MH_lst[indxval];
                        //    MH_lst[indxval] = tmp;
                        //    maxheap(indxval, ref Listval);
                    }
                }
            }

            return MH_lst;
        }

        public void insert(int val)
        {
            MH_lst.Add((int)val);
            heapify(MH_lst.Count - 1);
        }
        public void removeat(int val)
        {
            int xx = 2 * val + 1;
            int yy = 2 * val + 2;
            if (xx >= MH_lst.Count - 1 || yy >= MH_lst.Count - 1)
            {
                MH_lst.RemoveAt(val);   
            }
            else
            {
                if (MH_lst[2*val+1]> MH_lst[2 * val + 2])
                {
                    
                    int tmp=MH_lst[val];
                    MH_lst[val] = MH_lst[xx];
                    MH_lst[xx] = tmp;
                    removeat(xx);
                }
                else
                {
                    
                    int tmp = MH_lst[val];
                    MH_lst[val] = MH_lst[yy];
                    MH_lst[yy] = tmp;
                    removeat(yy);
                }
            }
        }
        public void heapify(int indxval)
        {
            int yy = indxval;
            if (yy % 2 == 1)
            {
                if (yy - 1 == 0) indxval = 0;
                else indxval = (yy - 1) / 2;
            }
            else
            {
                if (yy - 2 == 0) indxval = 0;
                else indxval = (yy - 2) / 2;
            }

            if (indxval < 0) return;


                if (MH_lst[yy] >= MH_lst[indxval])
                {
                    int tmp = MH_lst[yy];
                    MH_lst[yy] = MH_lst[indxval];
                    MH_lst[indxval] = tmp;
                    heapify(indxval);
                }
            
        }
    }
        

    public class minheap
    {
        public List<int> MH_lst = new List<int>();

        public void insert(int val)
        {
            MH_lst.Add((int)val);
            heapify(MH_lst.Count - 1);
        }
        public void removeat(int val)
        {
            int xx = 2 * val + 1;
            int yy = 2 * val + 2;
            if (xx >= MH_lst.Count - 1 || yy >= MH_lst.Count - 1)
            {
                MH_lst.RemoveAt(val);
            }
            else
            {
                if (MH_lst[2 * val + 1] < MH_lst[2 * val + 2])
                {

                    int tmp = MH_lst[val];
                    MH_lst[val] = MH_lst[xx];
                    MH_lst[xx] = tmp;
                    removeat(xx);
                }
                else
                {

                    int tmp = MH_lst[val];
                    MH_lst[val] = MH_lst[yy];
                    MH_lst[yy] = tmp;
                    removeat(yy);
                }
            }
        }
        public List<int> heap(int idx, ref List<int> Listval)
        {
            int indxval = 0;
            for (int yy = idx; yy < Listval.Count; yy++)
            {
                if (MH_lst.Count == 0)
                {
                    if (MH_lst.Count < Listval.Count)
                        MH_lst.Add(Listval[yy]);
                }
                else
                {


                    if (yy % 2 == 1)
                    {
                        if (yy - 1 == 0) indxval = 0;
                        else indxval = (yy - 1) / 2;
                    }
                    else
                    {
                        if (yy - 2 == 0) indxval = 0;
                        else indxval = (yy - 2) / 2;
                    }

                    if (indxval < 0) break;
                    if (MH_lst.Count < Listval.Count )
                        MH_lst.Add(Listval[yy]);

                    

                    if (MH_lst[yy] <= MH_lst[indxval])
                    {
                        heapify(yy);
                        //    int tmp = MH_lst[yy];
                        //    MH_lst[yy] = MH_lst[indxval];
                        //    MH_lst[indxval] = tmp;
                        //    minheap(indxval, ref Listval,true);
                        //}
                    }
                }
            }


            return MH_lst;
        }

        public void heapify(int indxval)
        {
            int yy = indxval;
            if (yy % 2 == 1)
            {
                if (yy - 1 == 0) indxval = 0;
                else indxval = (yy - 1) / 2;
            }
            else
            {
                if (yy - 2 == 0) indxval = 0;
                else indxval = (yy - 2) / 2;
            }

            if (indxval < 0) return;


                if (MH_lst[yy] <= MH_lst[indxval])
                {
                    int tmp = MH_lst[yy];
                    MH_lst[yy] = MH_lst[indxval];
                    MH_lst[indxval] = tmp;
                    heapify(indxval);
                }

        }

    }
    public class AdjustList : IComparable<AdjustList>
    {
        private int vertex, weight;
        public AdjustList(int v,int w)
        {
            vertex = v;
            weight = w;
        }
        public int getvertex() {return vertex;}
        public int getweight() { return weight; }

        public int CompareTo(AdjustList other)
        {
            return weight - other.weight;
        }
    }
    public class DJI_kstra
    {
        List<List<AdjustList>> graph;
        int V;
        public DJI_kstra()
        {
            V = 9;
            graph = new List<List<AdjustList>>();
            for(int yy=0;yy<V;yy++)
            {
                graph.Add(new List<AdjustList>());
            }
            graph[0].Add(new AdjustList(1, 4));
            graph[0].Add(new AdjustList(7, 8));
            graph[1].Add(new AdjustList(2, 8));
            graph[1].Add(new AdjustList(7, 11));
            graph[1].Add(new AdjustList(0, 4));
            graph[2].Add(new AdjustList(1, 8));
            graph[2].Add(new AdjustList(3, 7));
            graph[2].Add(new AdjustList(8, 2));
            graph[2].Add(new AdjustList(5, 4));
            graph[3].Add(new AdjustList(2, 7));
            graph[3].Add(new AdjustList(4, 9));
            graph[3].Add(new AdjustList(5, 14));
            graph[4].Add(new AdjustList(3, 9));
            graph[4].Add(new AdjustList(5, 10));
            graph[5].Add(new AdjustList(4, 10));
            graph[5].Add(new AdjustList(6, 2));
            graph[5].Add(new AdjustList(3, 14));
            graph[6].Add(new AdjustList(5, 2));
            graph[6].Add(new AdjustList(7, 1));
            graph[6].Add(new AdjustList(8, 6));
            graph[7].Add(new AdjustList(0, 8));
            graph[7].Add(new AdjustList(1, 11));
            graph[7].Add(new AdjustList(6, 1));
            graph[7].Add(new AdjustList(8, 7));
            graph[8].Add(new AdjustList(2, 2));
            graph[8].Add(new AdjustList(6, 6));
            graph[8].Add(new AdjustList(7, 7));

        }
        public int[] Solve_shortpath()
        {
            int[] distance= new int[V];
            for (int uu=0;uu<V;uu++)
                distance[uu]=Int32.MaxValue;

            distance[0] = 0;

            SortedSet<AdjustList> adjnlist= new SortedSet<AdjustList>();
            adjnlist.Add(new AdjustList(0, 0));

            while(adjnlist.Count>0)
            {
                AdjustList current=adjnlist.First();
                adjnlist.Remove(current);


                foreach(AdjustList nxt in graph[current.getvertex()])
                {
                    if (distance[current.getvertex()]+ nxt.getweight() < distance[nxt.getvertex()])
                    {
                        distance[nxt.getvertex()]= nxt.getweight()+ distance[current.getvertex()];
                        adjnlist.Add(new AdjustList(nxt.getvertex(), distance[nxt.getvertex()]));
                    }

                }



            }
            return distance;
        }
    }

    class Treis
    {
        int alph_sz = 26;
        Dictionary<char, Treis> chaar;
        bool is_end;
        public Treis()
        {
            is_end=false;
            chaar = new Dictionary<char, Treis>();
        }

        public void Insert(string Addstr)
        {
            Dictionary<char,Treis> child =chaar;

            int lenn= Addstr.Length;    
            for (int uu=0;uu<lenn;uu++)
            {
                char cc=Addstr[uu];
                if (child.ContainsKey(cc))
                {
                    if (uu == lenn - 1) child[cc].is_end = true;
                    child = child[cc].chaar;
                    
                }
                else
                {
                    
                    child.Add(cc,new Treis());
                    if (uu == lenn - 1) child[cc].is_end = true;
                    child = child[cc].chaar;
                    
                }
                
                    
            }

            return;
        }       

        public bool search(string chkstr)
        {
            Dictionary<char, Treis> child = chaar;
            bool retval = false;
            int lenn= chkstr.Length;    
            for (int uu=0;uu< lenn; uu++)
            {
                char cc = chkstr[uu];
                if (child.ContainsKey(cc))
                {
                    
                    if ((uu== lenn-1) && (child[cc].is_end))
                    {
                        retval = true;
                        return retval;
                    }
                    child = child[cc].chaar;
                }
                else
                {
                    return retval;
                }
            }

            return retval;
        }
    }
    //public class DerivedClass1 : BaseClass
    //{
    //    void Access()
    //    {
    //        var baseObject = new BaseClass();

    //        var der = new DerivedClass1();
    //        // Error CS1540, because myValue can only be accessed by
    //        // classes derived from BaseClass.
    //        // baseObject.myValue = 5;

    //        // OK, accessed through the current derived class instance
    //        der.myValue = 5;

    //    }
    //}

}

