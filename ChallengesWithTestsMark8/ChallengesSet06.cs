using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                if (words.Any(w => w.ToLower() == word.ToLower()))
                {
                    return true;
                }
            }
            else if (words.Contains(word) && ignoreCase == false)
            {
                return true;
            }
           
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            bool isPrime = false;
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
            }

            if (num == 1)
            {
                isPrime = false;
            }

            if (num == 2 || num == 3)
            {
                isPrime = true;
            }

           
            return isPrime;

        }

        public int IndexOfLastUniqueLetter(string str)
        {
            /* for (int i = str.Length - 1; i >= 0; i--)
             {
                 char c = str[i];
                 if(str.LastIndexOf(c) == i)
                 {
                     return i;
                 }
             }
             return -1;
            */
            int index = -1;
            bool uniIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uniIndex = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniIndex = false;
                    }
                }
                if(uniIndex ==  true)
                {
                    index = i;
                }
            }
            return index;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 1;
            int currentCount = 1;
            
            for (int i = 1; i < numbers.Length;i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
            }

            return Math.Max(maxCount,currentCount);
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements is null || n <= 0)
            {
                return new double[0];
            }
            var everyNth = elements.Where((x, i) => (i + 1) % n == 0);

            return everyNth.ToArray(); 
        }
    }
}
