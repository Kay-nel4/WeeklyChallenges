using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }

            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }

            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //Was wondering why this won't pass all the tests
            //var sum = numbers.Sum();
            //return sum;

            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int stringLength = str1.Length;
            int stringLengthTwo = str2.Length;
            if (stringLength < stringLengthTwo)
            {
                return stringLength;
            }
            return stringLengthTwo;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var sum = numbers.Sum();
            return sum;
            
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var filteredNumbers = numbers.Where(n => n % 2 == 0).ToArray();
            return filteredNumbers.Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return numbers.Sum() % 2 != 0;
            //My first attempt I couldn't tell which tests it wasn't passing.
            /*int numSum = numbers.Sum();
            if (numSum % 2 != 0 || numSum == null)
            {
                return true;
            }
            return false;*/
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            
            return number / 2;
            
                
            
            //Attempt before watching exercise.
           /* for (int i = 0; i < number; i++)
            {
                return number.ToString().Count();
            }
            return 0;*/
            
        }
    }
}
