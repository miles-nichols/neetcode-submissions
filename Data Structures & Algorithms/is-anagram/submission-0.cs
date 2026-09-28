public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        List<char> chars = s.ToList();

        foreach (char c in t) {
            if (chars.Contains(c))
                chars.Remove(c);
            else
                return false;
        }

        return true;
    }
}
