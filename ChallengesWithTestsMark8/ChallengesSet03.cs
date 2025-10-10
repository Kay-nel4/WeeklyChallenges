using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }
            foreach (var val in vals)
            {
                if (val == false)
                {
                    return true;
                }
            }
            return false;
            //return vals != null && vals.Length != 0 && vals.Contains(true);

        }
        

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            /*int oddSum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    oddSum += number;
                    {
                        if (oddSum % 2 == 0)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;*/
            return numbers != null && numbers.Where(n => n % 2 != 0).Sum() % 2 != 0;
        }

        
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            /*if (password == null)
            {
                return false;
            }

            if (password.Any(p => char.IsUpper(p) && char.IsLower(p) && char.IsDigit(p)))
            {
                return true;
            }
            return false;*/
            bool isLower = false;
            bool isDigit = false;
            bool isUpper = false;

            foreach (var item in password)
            {
                if (char.IsUpper(item))
                {
                    isUpper = true;
                }
                
                if (char.IsDigit(item))
                {
                    isDigit = true;
                }
                
                if (char.IsLower(item))
                {
                    isLower = true;
                }
            }

            return isLower && isDigit && isUpper;



        }
        

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            List<int>oddsUnder100 = Enumerable.Range(1, 100).ToList();
            foreach(int num in oddsUnder100)
                if (num % 2 != 0)
                {
                    return oddsUnder100.Where(n => n % 2 != 0).ToArray();
                    
                }
            return oddsUnder100.Where(n => n % 2 == 0).ToArray();
                    
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
