class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        maxSum = -sys.maxsize - 1
        windowSum = 0
        start = 0
        for end in range(len(nums)):
            windowSum += nums[end]
            maxSum = max(maxSum, windowSum)
            
            while windowSum < 0 and start <= end:
                windowSum -= nums[start]
                start += 1
                
        return maxSum