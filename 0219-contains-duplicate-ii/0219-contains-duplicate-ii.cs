public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int start = 0;
        int end = 0;
        
        HashSet<int> mySet = new HashSet<int>();
        
        while(end < nums.Length){
            
            if(end - start > k){
                mySet.Remove(nums[start]);
                start++;
            }
            
            if(!mySet.Add(nums[end])){
                return true;
            }
            
            mySet.Add(nums[end]);
            end++;
        }
        
        return false;
    }
}