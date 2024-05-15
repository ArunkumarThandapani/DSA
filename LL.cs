using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class LL
    {
        int cnt = 1;

        public int value;

        public LL next_node;

        public LL()
        {
            next_node = null;
        }

        private LL(int Value)
        {
            value = Value;
            next_node = null;
        }

        
        static LL head;
        public LL return_ll(List<int> all_lst)
        {

            head = new LL(all_lst[0]);

            linked_list_data(all_lst, ref head, cnt);


            return head;
        }


        public LL return_Fun_LL(List<int> all_lst) 
        {
            LL prev = null;
            LL cur = null;
            LL next = null;
            LL head = null;
            for (int i = 0; i < all_lst.Count; i++)
            {
                if (i == 0)
                {
                    cur = new LL(all_lst[i]);
                    next = cur.next_node;
                    head = cur;
                }
                else
                {
                    prev = cur;
                    LL tmp = new LL(all_lst[i]);
                    
                    next = tmp.next_node;
                    cur = tmp;
                }
            }
            
            return cur;
            
        }

        public LL reverse_linkedlist(LL A, int B)
        {
            LL cur = A;
            LL prev = null;

            int cnt = 0;
            while (cur != null && cnt < B)
            {

                LL tmp = cur.next_node;

                cur.next_node = prev;
                prev = cur;

                cur = tmp;


                cnt++;

            }
            A.next_node = cur;
            return prev;
        }
        public LL reverse(LL A, int B)
        {
            if (A == null) return null;
            LL head = null;
            LL prev = null;
            LL cur = A;
            int cnt = 0;
            while (cur != null)
            {

                LL temp = reverse_linkedlist(cur, B);

                if (head == null)
                    head = temp;
                else
                    prev.next_node = temp;

                prev = cur;

                cur = cur.next_node;


            }
            return head;
        }

        public LL delete_LL(int position)
        {
            int sz = size(head);
            if (sz < position) return head;
            LL H_LL = head;
            if (position == 1)
            {
                return head.next_node;
            }
            else
            {
                for (int i = 0; i < position; i++)
                {
                    if (i == position - 1)
                    {
                        H_LL.next_node = H_LL.next_node.next_node;
                        return head;
                    }
                    H_LL = H_LL.next_node;
                }

                return head;
            }
        }

        public LL reverse_LL_base_int(LL A, int B)
        {
            LL cur = A;
            LL head = null;
            LL prev = null;
            while (cur != null)
            {

                LL temp = reverse_linked_list(cur, B);

                if (head == null)
                    head = temp;
                else
                    prev.next_node = temp;

                prev = cur;

                cur = cur.next_node;

            }

            return head;
        }

        public LL reverse_linked_list(LL A, int B)
        {
            LL cur = A;
            LL prev = null;
            int cnt = 0;
            while (cur != null && cnt < B)
            {
                LL tmp = cur.next_node;
                cur.next_node = prev;
                prev = cur;
                cur = tmp;
                cnt++;
            }
            A.next_node = cur;
            return prev;
        }
        public LL insert_LL(int val, int position)
        {
            LL ll = new LL(val);
            LL H_LL = head;
            int sz = size(head);
            if (sz < position) return head;
            if (position == 1)
            {
                ll.next_node = H_LL;
                return ll;
            }
            else
            {
                for (int i = 0; i < position; i++)
                {
                    if (i == position - 1)
                    {
                        ll.next_node = H_LL.next_node;
                        H_LL.next_node = ll;
                        return head;
                    }
                    H_LL = H_LL.next_node;

                }

            }

            return head;
        }
        public void print_all()
        {
            LL H_LL = head;
            while (H_LL != null)
            {
                Console.WriteLine(H_LL.value);
                Console.WriteLine("");
                H_LL = H_LL.next_node;
            }
        }
        public LL removeNthFromEnd(LL A, int B)
        {
            int sz = size(A);
            if (sz < B) return head;
            LL H_LL = A;
            int totcnt = size(A);
            int finval = (totcnt - B);
            if (finval <= 1)
            {
                H_LL = H_LL.next_node;
                return A.next_node;
            }
            else
            {
                for (int i = 0; i < finval; i++)
                {
                    if (i == finval - 1)
                    {
                        H_LL.next_node = H_LL.next_node.next_node;
                        return A;
                    }
                    H_LL = H_LL.next_node;
                }

                return A;
            }
        }
        public int size(LL A)
        {
            int cnt = 0;
            LL H_LL = A;
            while (H_LL != null)
            {
                H_LL = H_LL.next_node;
                cnt++;
            }
            return cnt;
        }

        private LL linked_list_data(List<int> int_lst, ref LL accum, int CNT)
        {
            if (CNT < int_lst.Count)
            {
                accum.next_node = new LL(int_lst[CNT]);
                if (CNT == int_lst.Count - 1) 
                    return accum;
            }
            else
            {
                return accum;
            }


            CNT++;
            linked_list_data(int_lst,ref accum.next_node, CNT);

            return accum;

        }
        public LL deleteDuplicates(LL A)
        {
            LL first = A;
            LL second = A.next_node;

            while (first != null & second != null)
            {
                if (first.value == second.value)
                {

                    second = second.next_node;
                    first.next_node = second;
                }
                else
                {
                    first = first.next_node;
                    second = second.next_node;
                }
            }
            return A;
        }
    }
}
