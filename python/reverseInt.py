# Reverse interger (32-bit) - medium difficulty
class Solution:
    def reverse(self, x: int) -> int:
        temp = str(x)
        if (temp[0] == '-'):
            temp = temp[1:]
            temp += '-'
        temp = int(temp[::-1])
        if ((temp >= 2**31) or (temp <= -2**31 - 1)):
            return 0
        return temp


t = Solution()
r = t.reverse(-5325327)
