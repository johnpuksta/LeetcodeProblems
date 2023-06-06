# Longest Palindrome Substring - Medium Difficulty
class Solution:
    def longestPalindrome(self, s: str) -> str:
        start, last = 0, 0

        for x in range(len(s)):
            if (s[0] == s[x]):
                longest = s[0:x+1]
                continue
            break

        for i in range(len(s)):
            try:
                while (s[i] == s[i+1+last]):
                    last += 1
                while (s[start+i-1] == s[last+i+1] and start+i-1 >= 0):
                    start -= 1
                    last += 1
            except:
                pass
            if (len(s[start+i:last+i+1]) > len(longest)):
                longest = s[start+i:last+i+1]
            start, last = 0, 0
        return longest


t = Solution()
r = t.longestPalindrome("adam")
