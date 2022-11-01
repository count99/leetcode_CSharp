public class Solution {
    public bool IsIsomorphic(string s, string t)
    {
        bool answer = true;
        string temp_word = "";
        Dictionary<char, char> MyDic = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (MyDic.ContainsKey(s[i]))
            {
                if (t[i] != MyDic[s[i]])
                {
                    answer = false;
                    break;
                }
                temp_word += s[i];
            }
            else
            {
                if (MyDic.ContainsValue(t[i]))
                {
                    answer = false;
                    break;
                }
                else
                {
                    MyDic.Add(s[i], t[i]);
                    temp_word += s[i];
                }
            }
        }
        if (temp_word != s)
        {
            answer = false;
        }
        return answer;
    }

    public static void Main()
    {
        Solution first = new Solution();
        string s = "bbbaaaba";
        string t = "aaabbbba";
        bool answer = first.IsIsomorphic(s, t);
        Console.WriteLine(answer);
    }
}