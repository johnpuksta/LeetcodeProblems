# Palindrome Number - Easy Difficulty

class Solution:
    def isPalindrome(self, x: int) -> bool:
        temp = str(x)
        try:
            temp = int(temp[::-1])
            if (temp == x):
                return True
        except:
            return False
        return False


t = Solution()
r = t.isPalindrome(121)
pass
