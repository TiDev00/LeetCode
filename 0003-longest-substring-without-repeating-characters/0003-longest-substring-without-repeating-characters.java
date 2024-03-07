class Solution {
    public int lengthOfLongestSubstring(String s) {
        int maxSize = 0;
        int windowSize = 0;
        int start = 0;
        Set<Character> mySet = new HashSet<>();
        for(int end = 0; end < s.length(); end++){
            char currentChar = s.charAt(end);
            
            while(mySet.contains(currentChar)){
                mySet.remove(s.charAt(start));
                windowSize -= 1;
                start++;
            }
            
            mySet.add(currentChar);
            windowSize += 1;
            maxSize = Math.max(maxSize, windowSize);
        }
        return maxSize;
    }
}