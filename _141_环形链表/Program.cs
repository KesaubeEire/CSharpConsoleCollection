namespace _141_环形链表
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }

        public static bool HasCycle(ListNode head)
        {
            return false;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    }
}

//DES:
//https://leetcode-cn.com/problems/linked-list-cycle/