class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        maxSize = 0
        windowSize = 0
        start = 0
        mySet = set()
        for end in range(len(s)):
            currentChar = s[end]
            
            while currentChar in mySet:
                mySet.remove(s[start])
                windowSize -= 1
                start += 1
            
            mySet.add(currentChar)
            windowSize += 1
            maxSize = max(maxSize, windowSize)
        
        return maxSize