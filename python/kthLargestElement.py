# Kth Largest Element in a Stream - Easy Difficulty
class KthLargest:

    def __init__(self, k: int, nums: list[int]):
        self.k = k
        self.nums = nums

    def add(self, val: int) -> int:
        self.nums.append(val)
        self.nums.sort()
        if (len(self.nums) < self.k):
            return self.nums[0]
        return self.nums[len(self.nums)-self.k]


t = KthLargest(1, [])
x = t.add(-3)
x = t.add(-2)
x = t.add(-4)
x = t.add(0)
x = t.add(4)

p = 2


# Your KthLargest object will be instantiated and called as such:
# obj = KthLargest(k, nums)
# param_1 = obj.add(val)
