public class Solution {
    
    public bool IsSubsequence(string s, string t)
    {
        bool answer = false;

        for (int i = 0; i < t.Length; i++)
        {
            if (s.Length == 0)
            {
                break;
            }

            {
                if (t[i] == s[0])
                {
                    s = s.Remove(0, 1);
                }
            }
        }

        if (s.Length == 0)
        {
            answer = true;
        }

        return answer;
    }

    public static void Main()
    {
        string s = "";
        string t = "abc";
        Solution test = new Solution();
        bool ans = test.IsSubsequence(s, t);
        Console.Write(ans);
    }
}