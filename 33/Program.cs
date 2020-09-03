/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 */

// @lc code=start
public class Solution {
    public int Search(int[] nums, int target) {
        int left, mid, right;
        left = 0;
        right = nums.Length - 1;

        while (left <= right){
            mid = left + (right - left) / 2;

            if (nums[mid] == target){
                return mid;
            }

            if (nums[left] <= nums[mid]){            // left ~ mid is sorted
                if (target <= nums[mid] && nums[left] <= target){
                    right = mid - 1;
                }
                else{
                    left = mid + 1;
                }
            }
            else{                                   // mid ~ right is sorted
                if (target >= nums[mid] && nums[right] >= target){
                    left = mid + 1;
                }
                else{
                    right = mid - 1;
                }
            }
        }

        return -1;
    }

    // public static void Main(){
    //     Solution sol = new Solution();
    //     //int[] input = {2, 4, 5, 6, 7, 0, 1};
    //     //int[] input = {6, 7, 0, 1, 2, 4, 5};
    //     //int[] input = {4,5,6,7,0,1,2};
    //     int[] input = {3,1};
    //     System.Console.WriteLine(sol.Search(input, 1));
    // }
}
// @lc code=end

