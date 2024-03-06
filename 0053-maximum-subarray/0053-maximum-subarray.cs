public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = int.MinValue;
        int windowSum = 0;
        int start = 0;
        for(int end = 0; end < nums.Length; end++){
            windowSum += nums[end];
            maxSum = Math.Max(maxSum, windowSum);
            
            while(windowSum < 0 && start <= end){
                windowSum -= nums[start];
                start++;
            }
        }
        return maxSum;
    }
}