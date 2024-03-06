class Solution {
    public int maxSubArray(int[] nums) {
        int maxSum = Integer.MIN_VALUE;
        int windowSum = 0;
        int start = 0;
        int end = 0;
        while(end < nums.length){
            windowSum += nums[end];
            maxSum = Math.max(maxSum, windowSum);
            while(windowSum < 0 && start <= end){
                windowSum -= nums[start];
                start++;
            }
            end++;
        }
        return maxSum;
    }
}