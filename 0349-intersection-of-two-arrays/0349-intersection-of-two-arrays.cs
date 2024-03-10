public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>();
        foreach(int val in nums1){
            set1.Add(val);
        }
        
        HashSet<int> set2 = new HashSet<int>();
        foreach(int val in nums2){
            set2.Add(val);
        }
        
        HashSet<int> finalSet = new HashSet<int>(set1);
        finalSet.IntersectWith(set2);
        
        int[] result = new int[finalSet.Count];
        int index = 0;
        foreach(int val in finalSet){
            result[index] = val;
            index++;
        }
        
        return result;
    }
}