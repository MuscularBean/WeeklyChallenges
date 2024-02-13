using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var nextNum = ((startNumber / n) + 1) * n;
            return nextNum;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var bus in businesses)
            {
                if (bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }
            }
            
        }
        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }
            var sortedNum = numbers.OrderBy(x => x).ToArray();

            return Enumerable.SequenceEqual(numbers, sortedNum);
            
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                { 
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
           if (words == null || words.Length == 0)
           {
               return "";
           }

            string res = string.Join(" ", words.Select(word => word.Trim()).Where(word => !string.IsNullOrEmpty(word)));

            return res.Length > 0 ? res + "." : "";
            
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements is null)
            {
                return new double[0];
            }

            var fourth = elements.Where((x, i) => (i + 1) % 4 == 0);

            return fourth.ToArray(); 
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null)
            {
                return false;
            }

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums.Contains(targetNumber - nums[i]) && Array.IndexOf(nums, targetNumber - nums[i]) != i)
                {
                    return true;
                }
               
            }
            return false;
             
        }
    }
}
