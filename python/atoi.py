# String to Integer (atoi) - medium difficulty
class Solution:
    def myAtoi(self, s: str) -> int:
        s = s.strip()
        if ((len(s)) == 0 or (s == "+") or (s == "-")):
            return 0
        retVal = ""
        startIndex = 0
        validDigits = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        if (s[0] == "-"):
            retVal += "-"
            startIndex += 1
            if (s[1] not in validDigits):
                return 0
        elif (s[0] == "+"):
            startIndex += 1
            if (s[1] not in validDigits):
                return 0
        if (s[0] not in validDigits and startIndex != 1):
            return 0
        for i in range(startIndex, len(s)):
            if (s[i] in validDigits):
                retVal += s[i]
                continue
            break

        retVal = int(retVal)
        if (retVal > 2**31 - 1):
            retVal = 2**31 - 1
        elif (retVal < -2**31):
            retVal = -2**31
        return retVal


t = Solution()
r = t.myAtoi("1243")
