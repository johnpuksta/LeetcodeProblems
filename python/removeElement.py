class Solution:
    def removeElement(self, nums: list[int], val: int) -> int:
        for i in range(nums.count(val)):
            nums.remove(val)
        return len(nums)


t = Solution()
r = t.removeElement([0, 1, 2, 2, 3, 0, 4, 2], 2)
