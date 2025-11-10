using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int even = 0;
            int odd = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    even += number;
                }

                if (number % 2 != 0)
                {
                    odd += number;
                }
            }
            return even - odd;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> strings = new List <string>();
            strings.Add(str1);
            strings.Add(str2);
            strings.Add(str3);
            strings.Add(str4);
            int shortest = int.MaxValue;
            foreach (string s in strings)
            {
               if (s.Length < shortest) 
               {
                   shortest = s.Length;
               }
            }
            return shortest;
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> nums = new List<int>();
            nums.Add(number1);
            nums.Add(number2);
            nums.Add(number3);
            nums.Add(number4);
            int smallest = int.MaxValue;
            foreach (int i in nums)
            {
                if (i < smallest)
                { 
                    smallest = i;
                    
                }
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
           biz.Name = "TrueCoders";

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            /*if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }

            if (sideLength1 == sideLength2 && sideLength2 == sideLength3)
            {
                return true;
            }
            if (sideLength1 + sideLength2 ! > sideLength3 || sideLength2 + sideLength3 ! > sideLength1 ||
                sideLength3 + sideLength1 ! > sideLength2)
            {
                return false;
            }
            return true;*/
            //I can't tell why this would not work, I saved it to return to later.


            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;

        }

        public bool IsStringANumber(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                { 
                    return false;
                }

                if (input.Contains("#"))
                {
                    return false;
                }

                if (input.Contains("*"))
                {
                    return false;
                }
            }
            return true;
            //var isNumber = double.TryParse(input, out double number);
            
            //return isNumber;
            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var element = objs.Length;
            var mostOf = (element / 2) + 1;
            var amount = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    amount++;
                }
            }

            if (amount >= mostOf)
            {
                return true;
            }
            return false;

        }

        public double AverageEvens(int[] numbers)
        {
            /*double evens = 0;
            
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            
            foreach (int number in numbers)
                if (number % 2 == 0)
                {
                    evens++;
                    
                }
            double sum = evens / numbers.Length;
            return sum;*/
            //again this seems like it would work, I want to revisit it.

            double sum = 0;
            double count = 0;

            if (numbers == null)
            {
                return 0;
            }
            foreach (int number in numbers)
                if (number % 2 == 0)
                {
                    sum += number;
                    count++;
                }

            if (count > 0)
            {
                return sum / count;
            }
            return 0;

        }

        public int Factorial(int number)
        {
            var factorial = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
