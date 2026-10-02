class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
     
        if nums is None or target is None:
            return []

        d = {} 

        for index, num in enumerate(nums):
            complement = target - num

            if complement in d:
                return [d[complement], index]
        
            d[num] = index

        return []