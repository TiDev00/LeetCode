class Solution:
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        minSize = sys.maxsize
        found = False
        windowSize = 0
        windowSum = 0
        start = 0
        
        for end in range(len(nums)):
            
            windowSum += nums[end]
            windowSize += 1
            
            while windowSum >= target:
                found = True
                minSize = min(windowSize, minSize)
                windowSum -= nums[start]
                start += 1
                windowSize -= 1
            
        return minSize if found else 0