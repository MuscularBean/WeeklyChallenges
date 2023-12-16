using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var total = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    total += number;
                }
                else
                {
                    total -= number;
                }     
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();
        }

        public string ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            return biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 >  sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 >= sideLength2)
            {
                return true;
            }
            else
            { return false; }

        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out var number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;
            
            var count = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }
            
            if (count >= majority)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public double AverageEvens(int[] numbers)
        {
            List<double> evens = new List<double>();

           if (numbers == null)
           {
               return 0;
           }
            
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
            }
            
            if (evens.Count == 0)
            {
                return 0;
            }

            return evens.Average();
        }

        public int Factorial(int number)
        {
            var result = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }


            for (int x = number; x > 0; x--)
            {
                result *= x;
            }

            return result;

        }
    }
}
