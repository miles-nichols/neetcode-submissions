class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
     
        if nums is None or target is None:
            return []

        seen = {} 

        for key, value in enumerate(nums):
            complement = target - value

            if complement in seen:
                return [seen[complement], key]
        
            seen[value] = key

        return []
