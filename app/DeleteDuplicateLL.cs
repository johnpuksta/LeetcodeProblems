using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class DeleteDuplicateLL
    {
        public ListNode2 DeleteDuplicates(ListNode2 head) {
            if(head == null){
                return head;
            }
            ListNode2 retLL = new ListNode2();
            var tail = retLL;
            while(head != null && head.next != null){
                if(head.val != head.next.val){
                    tail.next = new ListNode2(head.val);
                    tail = tail.next;
                }
                head = head.next;
            }
            tail.next = new ListNode2(head.val);
            return retLL.next;
        }
    }
}
/*          program.cs
            int[] arr = { 1, 2, 2, 3, 4, 5, 6, 6 };
            ListNode2 retList = new ListNode2();
            var tail = retList;         
            for (int i = 0; i < arr.Length; i++){
                ListNode2 tempNode = new ListNode2(arr[i]);
                tail.next = tempNode;
                tail = tail.next;
            }
            DeleteDuplicateLL test = new DeleteDuplicateLL();
            var ret = test.DeleteDuplicates(retList.next);
*/