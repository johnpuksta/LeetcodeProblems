# Length Of last Word - Easy Difficulty
class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        words = s.split()
        return len(words[-1])


t = Solution()
t.lengthOfLastWord("Hello World")
