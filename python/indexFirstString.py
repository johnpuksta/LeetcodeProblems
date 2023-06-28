# Find the Index of the First Occurrence in a String - Easy Difficulty
class Solution:
    def strStr(self, haystack: str, needle: str) -> int:
        try:
            return haystack.index(needle)
        except (ValueError):
            return -1


t = Solution()
r = t.strStr("sadbutsad", "sada")
