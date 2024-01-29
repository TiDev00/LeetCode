class Solution:
    def isPalindrome(self, x: int) -> bool:
        nb = str(x)
        p1 = 0
        p2 = len(nb) - 1
        
        if x < 0:
            return False
        
        while p1 < p2:
            if nb[p1] != nb[p2]:
                return False
            p1 += 1
            p2 -= 1
        
        return True