// https://leetcode.com/problems/add-two-numbers/

namespace LeetCodeResolvedTasks.Medium.AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode nextObjL1 = l1;
            ListNode nextObjL2 = l2;
            ListNode result = new ListNode(0);
            ListNode innerResult = result;
            int temp = 0;
            do
            {
                innerResult.next = new ListNode(((nextObjL1.val + nextObjL2.val + temp) % 10));
                temp = (nextObjL1.val + nextObjL2.val + temp) / 10;
                nextObjL1 = nextObjL1.next;
                nextObjL2 = nextObjL2.next;
                innerResult = innerResult.next;

            } while (nextObjL1 != null && nextObjL2 != null);
            while (nextObjL1 != null)
            {
                innerResult.next = new ListNode(((nextObjL1.val + temp) % 10));
                temp = (nextObjL1.val + temp) / 10;
                innerResult = innerResult.next;
                nextObjL1 = nextObjL1.next;
            }
            while (nextObjL2 != null)
            {
                innerResult.next = new ListNode(((nextObjL2.val + temp) % 10));
                temp = (nextObjL2.val + temp) / 10;
                innerResult = innerResult.next;
                nextObjL2 = nextObjL2.next;
            }
            if (temp > 0)
            {
                innerResult.next = new ListNode(temp);
            }

            return result.next;
        }
    }
}
