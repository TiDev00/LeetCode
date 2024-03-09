class Solution:
    def maxFrequencyElements(self, nums: List[int]) -> int:
        myMap = Counter(nums)
        
        maxValue = max(myMap.values())
        
        result = 0
        for val in myMap.values():
            if val == maxValue:
                result += val
                
        return result