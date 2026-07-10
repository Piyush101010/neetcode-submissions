public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int size = nums.Length;
        int i = 0;

        while(i < size){
            if(nums[i] == val){
                nums[i] = nums[size - 1];
                size--;
            }
            else{
                i++;
            }
        }

        return size;

        
        
    }
}