# Maximum Subsequence Score - Medium Difficulty
# Fails due to memory limit exceeded
# Other solutions use heaps to avoid this

from itertools import combinations
from heapq import heappop, heappush


class Solution:
    def maxScoreExcessMemory(self, nums1: list[int], nums2: list[int], k: int) -> int:
        index, max = 0, 0
        # These lines take up excessive memory for large values of k
        combosNums1 = list(combinations(nums1, k))
        combosNums2 = list(combinations(nums2, k))

        for combo in combosNums1:
            if (sum(combo) * min(combosNums2[index]) > max):
                max = sum(combo) * min(combosNums2[index])
            index += 1
        return max

    def maxScore(self, nums1: list[int], nums2: list[int], k: int) -> int:
        heap, retVal, sum = [], 0, 0
        zipped = sorted(zip(nums2, nums1), reverse=True)

        for num2, num1 in zipped:
            if (len(heap) == k):
                sum -= heappop(heap)

            heappush(heap, num1)
            sum += num1
            if (len(heap) == k):
                retVal = max(retVal, num2 * sum)

        return retVal


t = Solution()
r = t.maxScore([1, 3, 3, 2], [2, 1, 3, 4], 3)
