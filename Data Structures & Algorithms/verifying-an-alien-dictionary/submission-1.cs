public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        var rank = new Dictionary<char, int>();
    for (int i = 0; i < order.Length; i++)
        rank[order[i]] = i;

    for (int i = 0; i < words.Length - 1; i++)
    {
        string w1 = words[i], w2 = words[i + 1];

        for (int j = 0; j < w1.Length; j++)
        {
            if (j >= w2.Length) return false;     

            if (rank[w1[j]] < rank[w2[j]]) break;  
            if (rank[w1[j]] > rank[w2[j]]) return false;
        }
    }

    return true;
    }
}