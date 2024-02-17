class Solution:
    def reverse(self, x: int) -> int:
        is_negative = False
        if x < 0:
            is_negative = True
        reversed_x = int(str(abs(x))[::-1])
        if reversed_x > 2**31 - 1:
            return 0
        return -reversed_x if is_negative else reversed_x