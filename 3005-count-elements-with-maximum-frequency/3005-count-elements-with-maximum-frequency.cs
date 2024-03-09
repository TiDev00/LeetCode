public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        
        Dictionary<int, int> myMap = new Dictionary<int, int>();
        
        foreach (int val in nums) {
            myMap[val] = myMap.GetValueOrDefault(val, 0) + 1;
        }
        
        int maxValue = int.MinValue;
        foreach (int val in myMap.Values){
            maxValue = Math.Max(maxValue, val);
        }
        
        int result = 0;
        foreach (int val in myMap.Values){
            if(val == maxValue){
                result += val;
            }
        }
        
        return result;
    }
}