public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int size = arr.Length;
        
        for(int i = 0; i < size; i++){
            if(i == size-1){
                arr[i] = -1;
            }
            else{
                int max = 0;
                for(int j = i + 1; j< size; j++){
                    max = Math.Max(max, arr[j]);

                }
                arr[i] = max;
            }
        }
        return arr;
    }
}