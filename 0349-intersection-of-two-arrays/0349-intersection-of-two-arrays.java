class Solution {
    public int[] intersection(int[] nums1, int[] nums2) {
        
        Set<Integer> set1 = new HashSet<>();
        for(Integer val : nums1){
            set1.add(val);
        }
        
        Set<Integer> set2 = new HashSet<>();
        for(Integer val : nums2){
            set2.add(val);
        }
        
        Set<Integer> finalSet = new HashSet<>(set1);
        finalSet.retainAll(set2);
        
        int[] result = new int[finalSet.size()];
        int index = 0;
        for(Integer val : finalSet){
            result[index] = val;
            index++;
        }
        
        return result;
    }
}