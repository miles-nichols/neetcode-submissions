class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        
        counts = {}

        for num in nums:
            if num not in counts:
                counts[num] = 0
            counts[num] += 1
        
        pairs = []
        for num, freq in counts.items():
            pairs.append((freq, num))
        
        pairs.sort(reverse = True)

        result = []
        for i in range(k):
            result.append(pairs[i][1])
        return result
        

        
