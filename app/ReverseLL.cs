using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class ReverseLL
    {
        public ListNode2 ReverseList(ListNode2 head) {
            List<int> tempL = new List<int>();
            while(head != null){
                tempL.Add(head.val);
                head = head.next;
            }
            tempL.Reverse();
            ListNode2 retLL = new ListNode2();
            var tail = retLL;
            foreach(int i in tempL){
                ListNode2 tempNode = new ListNode2(i);
                tail.next = tempNode;
                tail = tail.next;
            }
            return retLL.next;

        }
    } 
}