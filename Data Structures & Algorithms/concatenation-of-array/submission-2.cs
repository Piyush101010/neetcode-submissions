public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int size = 2 * n;

        int [] ans = new int [size];

        for(int i = 0; i<n; i++){
            ans[i] = nums[i];
            ans[i + n] = nums[i];
        }
        return ans;
    }
}