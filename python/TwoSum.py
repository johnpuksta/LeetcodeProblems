# Two Sum problem - Easy Difficulty
# Naive approach, bad time complexity
class Solution:
    def twoSum(self, nums: list[int], target: int) -> list[int]:
        temp = 0
        for j in range(0, len(nums) - 1):
            for i in range(0, len(nums)):
                temp = nums[j] + nums[i]
                if (temp == target and i != j):
                    return j, i
        return []

# hashmap, faster runtime but worse memory usage


class Solution1:
    def twoSum(self, nums: list[int], target: int) -> list[int]:
        d = {}
        for i, j in enumerate(nums):
            r = target - j
            if (r in d):
                return [i, d[r]]
            d[j] = i

# no hashmap, slower runtime but better memory usage


class Solution2:
    def twoSum(self, nums: list[int], target: int) -> list[int]:
        for i, j in enumerate(nums):
            r = target - j
            if (r in nums and nums.index(r) != i):
                return [i, nums.index(r)]


t = Solution2()
t.twoSum([0, 4, 3, 0], 0)
