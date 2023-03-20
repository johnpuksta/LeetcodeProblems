namespace app
{
    public class SolutionAddTwo {
        public ListNode2 AddTwoNumbers(ListNode2 l1, ListNode2 l2) {
            ListNode2 returnNode = new ListNode2();
            int carry = 0;
            while(l1!=null || l2!=null || carry!=0){
                int sum=0;
                if(l1!=null){
                    sum+=l1.val;
                    l1=l1.next;
                }
                if(l2!=null){
                    sum+=l2.val;
                    l2=l2.next;
                }
                sum+=carry;
                carry=sum/10;                

                ListNode2 new_node = new ListNode2(sum%10);
                ListNode2 last = returnNode;

                while (last.next != null)
                    last = last.next;
                last.next = new_node;
            }
            return returnNode.next;   
        }
    }
    public class ListNode2 {
        public int val;
        public ListNode2 next;
        public ListNode2(int val=0, ListNode2 next=null) {
            this.val = val;
            this.next = next;
        }
  }
}
//AddTwoNumbers program.cs
/*
            SolutionAddTwo sol = new SolutionAddTwo();
            var L1 = new ListNode2(2);
            var temp1 = new ListNode2(4);
            var temp2 = new ListNode2(3);
            L1.next = temp1;
            temp1.next = temp2;

            var L2 = new ListNode2(5);
            var temp3 = new ListNode2(6);
            var temp4 = new ListNode2(4);
            L2.next = temp1;
            temp1.next = temp4;
            var res = sol.AddTwoNumbers(L1,L2);
*/