class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        start = 0
        end = 0
        
        myMap = {}
        
        while end < len(nums):
            if end - start > k:
                del myMap[nums[start]]
                start += 1
                
            if nums[end] in myMap:
                return True
            
            myMap[nums[end]] = end
            end += 1
            
        return False
    