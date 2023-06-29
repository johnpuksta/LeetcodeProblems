# Is Valid Anagram - Easy Difficulty
class Solution:
    def isAnagram(self, s1: str, s2: str) -> bool:
        if (len(s1) != len(s2)):
            return False

        d1 = dict()
        d2 = dict()
        for s in s1:
            if s in d1:
                d1[s] += 1
            else:
                d1[s] = 1
        for s in s2:
            if s in d2:
                d2[s] += 1
            else:
                d2[s] = 1

        for c, num in d2.items():
            if c not in d1:
                return False
            if num != d1[c]:
                return False
        return True
