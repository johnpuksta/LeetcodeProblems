import itertools as iter


class Solution:
    def letterCombinations(self, digits: str) -> list[str]:
        if digits == "":
            return []

        possibleChars = []
        digitsMap = {'2': ['a', 'b', 'c'], '3': ['d', 'e', 'f'], '4': ['g', 'h', 'i'], '5': ['j', 'k', 'l'],
                     '6': ['m', 'n', 'o'], '7': ['p', 'q', 'r', 's'], '8': ['t', 'u', 'v'], '9': ['w', 'x', 'y', 'z']}

        for digit in digits:
            possibleChars.append(digitsMap[digit])

        return [''.join(p) for p in iter.product(*possibleChars)]


t = Solution()
r = t.letterCombinations("23")
