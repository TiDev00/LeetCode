public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int minSize = int.MaxValue;
        bool found = false;
        int windowSize = 0;
        int windowSum = 0;
        int start = 0;
        
        for(int end = 0; end < nums.Length; end++){
            
            windowSum += nums[end];
            windowSize++;
            
            while(windowSum >= target && start <= end){
                found = true;
                minSize = Math.Min(windowSize, minSize);
                windowSum -= nums[start];
                start++;
                windowSize--;
            }
        }
        
        return found ? minSize : 0;
    }
}