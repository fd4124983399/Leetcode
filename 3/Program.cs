using  System.Collections.Generic;

/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        int currentLength = 0;

        Dictionary<char, int> state = new Dictionary<char, int>();

        for (int i=0;i<s.Length;i++){
           if (!state.ContainsKey(s[i])){
                state[s[i]] = i;
                currentLength++;
            }
            else{
                if (currentLength > maxLength){
                    maxLength = currentLength;
                }

                i = state[s[i]];
                state.Clear();
                currentLength = 0;
            }
        }

        if (currentLength > maxLength){
            maxLength = currentLength;
        }

        return maxLength;
    }

    // public static void Main(){
    //     Solution sol = new Solution();
    //     string input = " ";
    //     System.Console.WriteLine(sol.LengthOfLongestSubstring(input));
    // }
}
// @lc code=end

