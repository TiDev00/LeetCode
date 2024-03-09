class Solution {
    public int maxFrequencyElements(int[] nums) {
        
        Map<Integer, Integer> myMap = new HashMap<>();
        for (Integer val : nums) {
            myMap.put(val, myMap.getOrDefault(val, 0) + 1);
        }
        
        int maxValue = Integer.MIN_VALUE;
        for(Integer val : myMap.values()){
            maxValue = Math.max(maxValue, val);
        }
        
        int result = 0;
        for(Integer val : myMap.values()){
            if(val == maxValue){
                result += val;
            }
        }
        
        return result;
    }
}