using System.Collections.Generic;

/*
 * @lc app=leetcode id=24 lang=csharp
 *
 * [24] Swap Nodes in Pairs
  */

// @lc code=start

// // // Definition for singly-linked list.
 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }
 
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if (head == null){
            return head;
        }

        List<ListNode> formerList = new List<ListNode>();
        List<ListNode> latterList = new List<ListNode>();

        while (head != null){
            formerList.Add(head);
            latterList.Add(head.next);

            if (head.next != null)
                head = head.next.next;
            else
                break;
        }

        // 1->2->3->4, after process "1, 2" to "2, 1", save "1"'s pointer
        ListNode dummyHead = null;
        for (int i=0;i<formerList.Count;i++){
            formerList[i].next = null;

            if (latterList[i] != null)
                latterList[i].next = formerList[i];

            if (dummyHead != null){

                if (latterList[i] != null)
                    dummyHead.next = latterList[i];
                else
                    dummyHead.next = formerList[i];
            }
            dummyHead = formerList[i];
        }

        if (latterList[0] != null)
            return latterList[0];
        else
            return formerList[0];   
    }
}// @lc code=end

