# Maximum Water Area in Container - Medium Difficulty
import math


class Solution:
    def maxArea(self, height: list[int]) -> int:
        i = 0
        j = len(height) - 1
        area = 0
        while (i != j):
            temp = abs(j-i) * min(height[i], height[j])
            if temp > area:
                area = temp
            if height[i] > height[j]:
                j -= 1
            else:
                i += 1
        return area


t = Solution()
r = t.maxArea([1, 8, 6, 2, 5, 4, 8, 3, 7])
