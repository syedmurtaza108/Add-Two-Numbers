using System;
using System.Numerics;

namespace Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode first = new ListNode(2);
            first.next = new ListNode(4);
            first.next.next = new ListNode(3);

            ListNode second = new ListNode(5);
            second.next = new ListNode(6);
            second.next.next = new ListNode(4);

            var answer = AddTwoNumbers(first, second);
            Console.WriteLine("eesfd8");
        }

        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string num1 = "", num2 = "";
            Traverse(l1, ref num1);
            Traverse(l2, ref num2);

            BigInteger sum = BigInteger.Parse(Reverse(num1)) + BigInteger.Parse(Reverse(num2));
            
            string finalAnswer = Reverse(sum.ToString());
            int[] values = new int[finalAnswer.Length];
            

            for (int i = 0; i < finalAnswer.Length; i++)
            {
                values[i] = int.Parse(finalAnswer[i].ToString());
            }
            ListNode start = new ListNode(values[0]);
            int index = 1;
            AddNode(values, ref start, ref index);
            return start;
        }

        static void Traverse(ListNode node, ref string num)
        {
            num += node.val.ToString();
            if (node.next == null) return;
            Traverse(node.next, ref num);
        }

        static void AddNode(int[] val, ref ListNode start, ref int index)
        {
            if (index == val.Length) return;
            start.next = new ListNode(val[index++]);
            AddNode(val, ref start.next,ref index);
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
