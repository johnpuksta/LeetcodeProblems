# Valid Number - Hard Difficulty
# I realized that mapping the input to a float rules out most invalid string inputs, except for infinity strings. So, just account for those strings and this prob is easily solved

class Solution:
    def isNumber(self, s: str) -> bool:
        banned = ["inf", "-inf", "+inf", "infinity",
                  "Infinity", "-Infinity", "+Infinity"]
        if (s in banned):
            return False
        try:
            float(s)
        except:
            return False
        return True


t = Solution()
r = t.isNumber("inf")
pass
