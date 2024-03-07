public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> mySet = new HashSet<int>();
        for(int ptr = 0; ptr < nums.Length; ptr++){
            if(!mySet.Add(nums[ptr])){
                return true;
            }
            else{
                mySet.Add(nums[ptr]);
            }
        }
        return false;
    }
}