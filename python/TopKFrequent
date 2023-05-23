# top K Frequent numbers in an array - Medium Difficulty

class Solution:
    def topKFrequent(self, nums: list[int], k: int) -> list[int]:
        nums.sort()
        numsAndCounts = dict()
        count = 0

        if (len(nums) == 1):
            return nums
        endVal = len(nums) - 2

        for i in range(len(nums)-1):
            if (i == endVal):
                if (nums[i] == nums[i+1]):
                    count += 2
                    numsAndCounts[nums[i]] = count
                    continue
                numsAndCounts[nums[i]] = count
                numsAndCounts[nums[i+1]] = 1
            if (nums[i] == nums[i+1]):
                count += 1
                continue
            count += 1
            numsAndCounts[nums[i]] = count
            count = 0

        sorted_keys = sorted(
            numsAndCounts, key=numsAndCounts.get, reverse=True)

        return sorted_keys[0:k]


nums = [5, 2, 5, 3, 5, 3, 1, 1, 3]
k = 2
t = Solution()
r = t.topKFrequent(nums, 2)
