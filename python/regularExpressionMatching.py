# Unfinished
# Regular Expression Matching - Hard Difficulty
class Solution:
    def isMatch2(self, s: str, p: str) -> bool:
        # if (p.__contains__('.*')):
        # return True
        sIndex = 0
        nextCharIsStar = True
        for i in range(len(p)):
            if (p[i] == '*'):
                nextCharIsStar = True
                while (p[i - 1] == s[sIndex] or p[i-1] == '.'):
                    sIndex += 1
                    if (sIndex == len(s) and i == len(p)-1):
                        return True
                    elif (sIndex == len(s) and p[i+1] != '*' and p[i+1] != s[-1]):
                        return False
                    elif (sIndex == len(s)):
                        sIndex -= 1
                        break
                continue
            if (nextCharIsStar == False):
                return False
            if (sIndex >= len(s)):
                sIndex -= 2
            elif (s[sIndex] != p[i] and p[i] != '.'):
                nextCharIsStar = False
                sIndex -= 1
            sIndex += 1
        if (sIndex < len(s)):
            return False
        return True

    def isMatch(self, s: str, p: str) -> bool:
        sIndex = 0
        prevEqual = True
        for i in range(len(p)):
            if sIndex == len(s):
                isPrevCancelledByStar = True
                if (p[i-1] == '*' and len(p[i:]) <= 1 and p[i] != s[sIndex - 1]):
                    return False
                if (sIndex > i and p[i-1] != '*'):
                    return False
                p = p[i:]
                for j in range(len(p)):
                    if (p[j] == '*'):
                        isPrevCancelledByStar = True
                        continue
                    if (isPrevCancelledByStar == False):
                        return False
                    isPrevCancelledByStar = False
                return True
            if p[i] == s[sIndex] or p[i] == '.':
                sIndex += 1
                prevEqual = True
                continue
            if (prevEqual == False and i == len(p)):
                return False
            prevEqual = False
            if p[i] == '*':
                while (p[i-1] == s[sIndex] or p[i-1] == '.'):
                    sIndex += 1
                    if (sIndex == len(s)):
                        break
        if (sIndex < len(s)):
            return False
        return True


t = Solution()
r = t.isMatch("a", "ab*")
