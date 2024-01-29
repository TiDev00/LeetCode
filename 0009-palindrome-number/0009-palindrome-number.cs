public class Solution {
    public bool IsPalindrome(int x) {
        
        String nb = x.ToString();
        int p1 = 0;
        int p2 = nb.Length - 1;
        
        if(x < 0){
            return false;
        }
        
        while(p1 < p2){
            if(nb[p1] != nb[p2]){
                return false;
            }
            p1++;
            p2--;
        }
        
        return true;
    }
}