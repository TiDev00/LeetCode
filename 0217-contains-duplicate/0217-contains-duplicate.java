class Solution {
    public boolean containsDuplicate(int[] nums) {
        Set<Integer> mySet = new HashSet<>();
        for(int ptr = 0; ptr < nums.length; ptr++){
            if(!mySet.add(nums[ptr])){
                return true;
            }
            else{
                mySet.add(nums[ptr]);
            }
        }
        return false;
    }
}