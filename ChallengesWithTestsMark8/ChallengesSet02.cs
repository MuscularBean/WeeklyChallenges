using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Xml.Schema;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 ==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 ==0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num %2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }
       
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            
            if (str1.Length <= str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
            
            
        }

        public static int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                var total = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    total += numbers[i];
                }
                return total;
            }
            
            
        }

        public int SumEvens(int[] numbers)
        {
            
            if (numbers == null)
            {
                return 0;
            }
            
            
            
            var total = 0;
            for (int i = 0;i < numbers.Length;i++)
            {
                if (numbers[i] % 2 ==0)
                {total += numbers[i];}
                    
            }
                return total;
            
            

            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            { return false; }

 
             return (numbers.Sum() % 2 != 0);
 
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if ( number < 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
