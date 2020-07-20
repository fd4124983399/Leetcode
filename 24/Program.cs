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

        
        if(head == null || head.next == null) return head;
        
        ListNode first = head;
        ListNode second = head.next;
        
        first.next = SwapPairs(second.next);
        second.next = first;
        return second;
        
    }
}// @lc code=end

