public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxSize = 0;
        int windowSize = 0;
        int start = 0;
        HashSet<char> mySet = new HashSet<char>();
        for(int end = 0; end < s.Length; end++){
            char currentChar = s[end];
            
            while(mySet.Contains(currentChar)){
                mySet.Remove(s[start]);
                windowSize -= 1;
                start++;
            }
            
            mySet.Add(currentChar);
            windowSize += 1;
            maxSize = Math.Max(maxSize, windowSize);
        }
        return maxSize;
    }
}