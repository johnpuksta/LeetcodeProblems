# Length Of Longest Substring - Medium Difficulty
class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        if (len(s) == 1):
            return 1

        retVal, endIndex, startIndex, retArr, = 0, 0, 0, []
        for c in s:
            endIndex += 1
            if (c not in retArr):
                retArr = s[startIndex:endIndex]

            retVal = max(retVal, len(retArr))
            retArr = s[startIndex:endIndex]

            while ({x for x in retArr if retArr.count(x) > 1}):
                startIndex += 1
                retArr = retArr[1::]
        return retVal


t = Solution()
r = t.lengthOfLongestSubstring("abccadda")
