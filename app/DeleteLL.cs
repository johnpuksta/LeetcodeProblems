using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class DeleteLL
    {
        public ListNode2 RemoveElements(ListNode2 head, int val) {
            if(head == null){
                return head;
            }
            ListNode2 retList = new ListNode2();
            var tail = retList;
            while(head != null){
                if(head.val != val){
                    tail.next = head;
                    tail = tail.next;
                }
                head = head.next;
            }
            tail.next = null;
            return retList.next;
        }
    }
}