using System.Collections.Generic;

namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// 
    /// Given a string, find the length of the longest substring without repeating characters. 
    /// For example, the longest substring without repeating letters for "abcabcbb" is "abc", which the length is 3. For "bbbbb" the longest substring is "b", with the length of 1.
    /// </summary>
    public class Problem003
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var length = s.Length;
            if (length <= 1)
                return length;

            var startIndex = 0;
            var endIndex = 1;
            var max = 0;
            var dict = new Dictionary<char, int>();

            while (endIndex < length)
            {
                var start = s[startIndex];
                dict[start] = startIndex;

                // until we find a match or reach the end of the string
                while (endIndex < length
                    && (!dict.ContainsKey(s[endIndex]) || (dict[s[endIndex]] < startIndex)))
                {
                    dict[s[endIndex]] = endIndex;
                    endIndex++;
                }

                var count = endIndex - startIndex;

                // if this the end of the string
                if (endIndex == length)
                {
                    if (s[startIndex] == s[endIndex - 1])
                        count -= 1;

                    if (count > max)
                        max = count;
                    return max;
                }

                // if not, we found a match
                //  a   b   c   d   b   c   d
                //      ^           ^
                //   startIndex   endIndex

                startIndex = dict[s[endIndex]] + 1;
                dict[s[endIndex]] = endIndex;
                endIndex += 1;

                if (count > max)
                    max = count;
            }

            // should never hit this
            return max;
        }
    }
}
