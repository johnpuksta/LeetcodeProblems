class Solution:
    def intToRoman(self, num: int) -> str:
        outStr = ""
        while num >= 1000:
            num = num - 1000
            outStr += 'M'

        if num >= 900:
            num = num - 900
            outStr += 'CM'

        if num >= 500:
            num = num - 500
            outStr += 'D'

        if num >= 400:
            num = num - 400
            outStr += 'CD'

        while num >= 100:
            num = num - 100
            outStr += 'C'

        if num >= 90:
            num = num - 90
            outStr += 'XC'

        if num >= 50:
            num = num - 50
            outStr += 'L'

        if num >= 40:
            num = num - 40
            outStr += 'XL'

        while num >= 10:
            num = num - 10
            outStr += 'X'

        if num == 9:
            num = num - 9
            outStr += 'IX'

        if num >= 5:
            num = num - 5
            outStr += 'V'

        if num == 4:
            num = num - 4
            outStr += 'IV'

        while num >= 1:
            num = num - 1
            outStr += 'I'

        return outStr


t = Solution()
r = t.intToRoman(58)
pass
