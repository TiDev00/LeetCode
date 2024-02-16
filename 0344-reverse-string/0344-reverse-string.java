class Solution {
    public void reverseString(char[] s) {
        int p1 = 0;
        int p2 = s.length - 1;
        while(p2 > p1){
            char tmp = s[p2];
            s[p2] = s[p1];
            s[p1] = tmp;
            p1++;
            p2--;
        }
    }
}