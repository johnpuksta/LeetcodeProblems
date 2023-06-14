# ZigZag Conversion - Medium Difficulty
from itertools import cycle


class Solution:
    def convert(self, s: str, numRows: int) -> str:
        if (numRows == 1):
            return s
        retStr = ""
        numDiags = numRows - 2
        for i in range(0, len(s), numRows + numDiags):
            retStr += s[i]

        steps = cycle([numDiags*2, 2])
        for n in range(1, numDiags+1):
            i = n
            while (i <= len(s)-1):
                retStr += s[i]
                i += next(steps)
            steps = cycle([numDiags*2 - 2*n, 2 + 2*n])

        for i in range(numRows-1, len(s), numRows + numDiags):
            retStr += s[i]

        return retStr


t = Solution()
r = t.convert("ABCDE", 5)
# "PAYPALISHIRING"
# "PINALSIGYAHRPI"
