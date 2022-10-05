using System.Collections.Generic;
using System.Linq;

namespace CleancodeKata.stage5
{
    /**
     * Refactor this code until all methods body is less then 5 lines, and you find the code clean.
     */
    public class Stage5
    {
        public bool IsEligible(string word)
        {
            if (word.Length >= 10)
            {
                var vowels = new List<char> {'a', 'e', 'i', 'o', 'u', 'y'};
                long nbVowels = word.ToCharArray().Where(vowels.Contains).Count();
                if (nbVowels >= 4)
                {
                    return true;
                }

                var specialLetters = new List<char> {'p', 'm'};
                long nbSpecialLetters = word.ToCharArray().Where(specialLetters.Contains).Count();
                if (nbSpecialLetters >= 3)
                {
                    return true;
                }
            }
            else
            {
                long nbLettersInUpperCase = word.ToCharArray().Where(c => c >= 'A' && c <= 'Z').Count();
                if (nbLettersInUpperCase >= 5)
                {
                    return true;
                }

                var vowels = new List<char> {'a', 'e', 'i', 'o', 'u', 'y'};
                long nbVowels = word.ToCharArray().Where(vowels.Contains).Count();
                if (nbVowels >= 3)
                {
                    return true;
                }
            }

            return false;
        }
    }
}