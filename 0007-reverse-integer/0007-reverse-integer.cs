public class Solution {
    public int Reverse(int x) {
        int reversed = 0;
        while(x != 0){
            int lastDigit = x % 10;
            if (reversed > int.MaxValue/10 || (reversed == int.MaxValue/10 && lastDigit > 7)){
                return 0;
            }
            if (reversed < int.MinValue/10 || (reversed == int.MinValue/10 && lastDigit < -8)){
                return 0;
            }
            reversed =  reversed*10 + lastDigit; 
            x /= 10;
        }
        return reversed;
    }
}