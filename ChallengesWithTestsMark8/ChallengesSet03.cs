using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        
        public bool ArrayContainsAFalse(bool[] vals)
        {
           return Array.Exists(vals, element => element != null && element == false);        
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
           
            if (numbers == null) return false;

            return (numbers.Sum() % 2 != 0);
            
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = password.Any(char.IsUpper);
            bool hasNumber = password.Any(char.IsNumber);
            bool hasLower = password.Any(char.IsLower);

            return hasUpper && hasNumber && hasLower;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor ==0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] oddsArray = new int[50]; 
            int oddsIndex = 0;

            for (int i = 1; i < 100; i += 2)
            { 
                oddsArray[oddsIndex] = i;
                oddsIndex++;
            }

            return oddsArray;



        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
