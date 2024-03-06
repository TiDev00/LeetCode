class Solution {
    public boolean containsNearbyDuplicate(int[] nums, int k) {
        int start = 0;
        int end = 0;
        
        Map<Integer, Integer> myMap = new HashMap<>();
        
        while(end < nums.length){
            
            if(end - start > k){
                myMap.remove(nums[start]);
                start++;
            }
            
            if(myMap.containsKey(nums[end])){
                return true;
            }
            
            myMap.put(nums[end], end);
            end++;
        }
        return false;
    }
}