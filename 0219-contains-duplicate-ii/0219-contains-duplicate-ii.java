class Solution {
    public boolean containsNearbyDuplicate(int[] nums, int k) {
        int start = 0;
        int end = 0;
        
        Set<Integer> mySet = new HashSet<>();
        
        while(end < nums.length){
            
            if(end - start > k){
                mySet.remove(nums[start]);
                start++;
            }
            
            if(!mySet.add(nums[end])){
                return true;
            }
            
            mySet.add(nums[end]);
            end++;
        }
        return false;
    }
}