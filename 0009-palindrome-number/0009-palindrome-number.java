class Solution {
    public boolean isPalindrome(int x) {
        String nb = Integer.toString(x);
        int p1 = 0;
        int p2 = nb.length() - 1;
        
        if(x < 0){
            return false;
        }
        
        while(p1 < p2){
            if(nb.charAt(p1) != nb.charAt(p2)){
                return false;
            }
            p1++;
            p2--;
        }
        
        return true;
    }
}