# Climbing Stairs - Easy Difficulty
class Solution:
    def climbStairs(self, n: int) -> int:
        fibArr = [1, 2, 3]
        for i in range(3, n+1):
            fibArr.append(fibArr[i-1]+fibArr[i-2])
        return fibArr[n-1]


t = Solution()
r = t.climbStairs(8)
