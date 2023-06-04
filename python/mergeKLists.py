# Merge k Sorted Lists - Hard Difficulty

# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    def mergeKLists(self, lists: list[ListNode]) -> ListNode:
        temp = []
        retList = None
        for l in lists:
            while (l):
                temp.append(l.val)
                l = l.next
        temp.sort(reverse=True)
        for t in temp:
            retList = ListNode(t, retList)
        return retList


t = Solution()
l1 = ListNode(1)
l1.next = ListNode(4)
l1.next.next = ListNode(5)
l2 = ListNode(1)
l2.next = ListNode(3)
l2.next.next = ListNode(4)
l3 = ListNode(2)
l3.next = ListNode(6)
r = t.mergeKLists([l1, l2, l3])
