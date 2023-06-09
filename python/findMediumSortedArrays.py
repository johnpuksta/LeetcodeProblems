# Median of Two Sorted Arrays - Hard Difficulty
class Solution:
    def findMedianSortedArrays(self, nums1: list[int], nums2: list[int]) -> float:
        combined = sorted(nums1 + nums2)
        l = len(combined)
        if (l % 2 == 0):
            return (combined[int(l/2)] + combined[int(l/2)-1])/2
        return float(combined[int(l/2)])


t = Solution()
r = t.findMedianSortedArrays([1, 2], [3, 4, 5])
