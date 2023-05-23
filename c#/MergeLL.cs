using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class MergeLL
    {
        public class ListNode3 {
            public int val;
            public ListNode3 next;
            public ListNode3(int val=0, ListNode3 next=null) {
                this.val = val;
                this.next = next;
                }
            }
         public ListNode3 MergeTwoLists(ListNode3 list1, ListNode3 list2) {
            ListNode3 retList = new ListNode3();
            var tail = retList;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }

                tail = tail.next;
            }
            if(list1 != null){
                tail.next = list1;
            }
            else{
                tail.next = list2;
            }
            return retList.next;
        }
    }
 
}