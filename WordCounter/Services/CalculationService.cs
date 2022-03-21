using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCounter.Services
{
    public class CalculationService
    {
        public int CountWords(string wordlist)
        {
            string pattern = @"\b[^\d\W]+\b"; // any word character, no numbers
            Regex regex = new Regex(pattern);

            var result = regex.Matches(wordlist).Count;
            return result;
        } 
        
        public int CountChars(string wordlist)
        {
            return wordlist.Length;
        }

        private static int WordCount(string word, string text)
        {
            var regex = new Regex(string.Format(@"\b{0}\b", word),
                              RegexOptions.IgnoreCase);
            return regex.Matches(text).Count;
        }
    }
}
