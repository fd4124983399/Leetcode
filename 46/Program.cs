using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var length = nums.Length;
        var result = new List<IList<int>>();
        if (length == 0)
            return result;
        else{
            RecursiveFunc(0, length, ref result, nums);
        }

        return result;
    }

    void RecursiveFunc(int start, int end, ref List<IList<int>> result, int[] nums){
        if (start == end){
            IList<int> output = new List<int>(nums);
            result.Add(output);
        }
        else{
            for (int i=start; i<end;i++){
                Swap(ref nums, start, i);
                RecursiveFunc(start + 1, end, ref result, nums);
                Swap(ref nums, start, i);
            }
        }
    }

    void Swap(ref int[] nums, int a, int b){
        int temp = nums[a];
        nums[a] = nums[b];
        nums[b] = temp;
    }

    // public static void Main(){
    //      Solution sol = new Solution();
    //      int[] nums = new int[] {1, 2, 3};
    //      IList<IList<int>> result = sol.Permute(nums);

    //      foreach(var answer in result){
    //          foreach (var c in answer){
    //              System.Console.Write(c);
    //          }
    //          System.Console.WriteLine();
    //      }
    // }
}