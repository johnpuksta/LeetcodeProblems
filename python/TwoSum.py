# Two Sum problem - Easy Difficulty
# Could use improvements, bad time complexity
class Solution:
    def twoSum(self, nums: list[int], target: int) -> list[int]:
        temp = 0
        for j in range(0, len(nums) - 1):
            for i in range(0, len(nums)):
                temp = nums[j] + nums[i]
                if (temp == target and i != j):
                    return j, i
        return []


t = Solution()
t.twoSum([0, 4, 3, 0], 0)
