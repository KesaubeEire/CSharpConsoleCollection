using System;

namespace _206_翻转链表
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            ListNode head = new ListNode(5);
            ListNode head01 = new ListNode(4);
            ListNode head02 = new ListNode(3);
            ListNode head03 = new ListNode(2);
            ListNode head04 = new ListNode(1);
            head.next = head01;
            head01.next = head02;
            head02.next = head03;
            head03.next = head04;
            var li = ReverseList(head);

            while (li != null)
            {
                Console.WriteLine(li.val);
                li = li.next;
            }
        }

        public static ListNode ReverseList(ListNode head)
        {
            ListNode resNode = null;
            // 学会了，建个临时变量替代参数是对时间复杂度友好的
            ListNode tempNode = head;
            while (tempNode != null)
            {
                ListNode newHead = tempNode.next;
                tempNode.next = resNode;
                resNode = tempNode;
                tempNode = newHead;
            }

            return resNode;

            // ListNode prev = null;
            // while (head != null)
            // {
            //     ListNode temp=head.next;
            //     head.next = prev;
            //     prev = head;
            //     head = temp;
            // }
            // return prev;
        }
    }
}