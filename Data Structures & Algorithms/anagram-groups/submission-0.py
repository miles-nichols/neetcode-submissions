class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        groups = {}
        for s in strs: #for each string
            count = [0] * 26 # create list of 26 values of 0

            # Loop through each character in the current string
            for char in s:
                count[ord(char) - ord('a')] += 1 # count[char ASCII value - a ASCII value to get it to be 0-26] add frequecy count

            key = tuple(count) #convert list to tuple for dictionary
            if key not in groups: # if frequecy count for ag is not in the dictionary
                groups[key] = [] # create a new ag list
            groups[key].append(s)
        return list(groups.values())




