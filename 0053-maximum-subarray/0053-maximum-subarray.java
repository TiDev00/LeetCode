class Solution {
    public int maxSubArray(int[] nums) {
        int maxSum = Integer.MIN_VALUE;
        int windowSum = 0;
        int start = 0;
        for(int end = 0; end < nums.length; end++){
            windowSum += nums[end];
            while(nums[end] > windowSum){
                windowSum -= nums[start];
                start++;
            }
            maxSum = Math.max(maxSum, windowSum);
        }
        return maxSum;
    }
}