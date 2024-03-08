class Solution {
    public int minSubArrayLen(int target, int[] nums) {
        int minSize = Integer.MAX_VALUE;
        boolean found = false;
        int windowSize = 0;
        int windowSum = 0;
        int start = 0;
        
        for(int end = 0; end < nums.length; end++){
            
            windowSum += nums[end];
            windowSize++;
            
            while(windowSum >= target && start <= end){
                found = true;
                minSize = Math.min(windowSize, minSize);
                windowSum -= nums[start];
                start++;
                windowSize--;
            }
        }
        
        return found ? minSize : 0;
    }
}