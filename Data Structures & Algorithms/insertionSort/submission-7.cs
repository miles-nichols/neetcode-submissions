// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        // 1. Correctly define the List of Lists
        List<List<Pair>> fin = new List<List<Pair>>();
        
        // Starting at 0 ensures we capture the first state of the array too
        for(int i = 0; i < pairs.Count; i++)
        {
            // 2. Store the entire Pair object, not just the Key
            Pair currentPair = pairs[i]; 
            int j = i - 1;

            // Compare using currentPair.Key
            while (j >= 0 && pairs[j].Key > currentPair.Key)
            {
                // Shift the entire Pair object
                pairs[j + 1] = pairs[j]; 
                j = j - 1;
            }
            
            // Insert the entire Pair object
            pairs[j + 1] = currentPair; 
            
            // 3 & 4. Use Add(), and create a NEW list (a snapshot) to store in fin
            fin.Add(new List<Pair>(pairs)); 
        }
        
        return fin;
    }
}