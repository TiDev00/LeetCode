class Solution {
    public int maxSubArray(int[] nums) {
        int maxSum = Integer.MIN_VALUE;
        int windowSum = 0;
        int start = 0;
        for(int end = 0; end < nums.length; end++){
            while(windowSum < 0 && start < end){
                windowSum -= nums[start];
                start++;
            }
            windowSum += nums[end];
            maxSum = Math.max(maxSum, windowSum);
        }
        return maxSum;
    }
}