# Group Anagrams Problem - Medium Difficulty
class Solution:
    def groupAnagrams(self, strs: list[str]) -> list[list[str]]:
        retList = []
        while (len(strs) > 0):
            temp = []
            n = len(strs)
            if (n == 1):
                temp.append(strs[0])
                retList.append(temp)
                return retList

            i = 1
            temp.append(strs[0])
            while (i < n):
                if (self.isAnagram(strs[0], strs[i])):
                    temp.append(strs[i])
                    strs.pop(i)
                    n -= 1
                else:
                    i += 1
            strs.pop(0)
            retList.append(temp)
        return retList

    def isAnagram(self, s1: str, s2: str) -> bool:
        if (len(s1) != len(s2)):
            return False

        d1 = {}
        d2 = {}
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


t = Solution()
r = t.groupAnagrams(["", "b", ""])
