using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTitleCase.UI
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string s)
        {
            string[] words = s.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                words[i] = char.ToUpper(word[0]) + word.Substring(1).ToLower();
            }

            return string.Join(' ', words);
        }
    }
}
