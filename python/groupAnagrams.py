# Group Anagrams Problem - Medium Difficulty
from isValidAnagram import Solution as AnaValidator


class Solution:
    def groupAnagramsNaive(self, strs: list[str]) -> list[list[str]]:
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
                if (AnaValidator.isAnagram(strs[0], strs[i])):
                    temp.append(strs[i])
                    strs.pop(i)
                    n -= 1
                else:
                    i += 1
            strs.pop(0)
            retList.append(temp)
        return retList

    def groupAnagrams(self, strs: list[str]) -> list[list[str]]:
        d = {}
        for s in strs:
            temp = "".join(sorted(s))
            if temp in d:
                d[temp].append(s)
                continue
            d[temp] = [s]
        return d.values()


t = Solution()
r = t.groupAnagrams(["", "b", ""])
