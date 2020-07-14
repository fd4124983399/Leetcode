/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
public class Solution {
    public string LongestPalindrome(string s) {
        int length = s.Length;
        int startIndex = 0, maxLength = 0;
        bool[,] state = new bool[length, length];

        for (int j=0;j<length;j++){
            for (int i=0;i<=j;i++){
                if (i == j){
                    state[i, j] = true;
                    UpdateSolution(i, j, ref startIndex, ref maxLength);
                }
                else if (i == (j - 1)
                         && s[i] == s[j]){
                    state[i, j] = true;
                    UpdateSolution(i, j, ref startIndex, ref maxLength);
                }
                else if (state[i+1, j -1]
                         && s[i] == s[j]){
                    state[i, j] = true;
                    UpdateSolution(i, j, ref startIndex, ref maxLength);
                }
                else{
                    state[i, j] = false;
                }
            }
        }

        return s.Substring(startIndex, maxLength);
    }

    void UpdateSolution(int i, int j, ref int startIndex, ref int maxLength){
        if (maxLength < (j - i + 1)){
            startIndex = i;
            maxLength = j - i + 1;
        }

    }

    // public static void Main(){
    //     Solution sol = new Solution();
    //     string input = "babad";
    //     System.Console.WriteLine(sol.LongestPalindrome(input));
    // }
}
// @lc code=end

