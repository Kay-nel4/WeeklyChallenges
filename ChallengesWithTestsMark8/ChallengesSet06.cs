using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase == true)
            {
                word = word.ToLower();
                
                List<string> lowerCase = words.Select(x => x.ToLower()).ToList();

                containsWord = lowerCase.Contains(word);
            }

            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
            
            //This was my attempt... It did solve some of them...
            /*foreach (string targetWord in words)
            {
                if (word != targetWord)
                { 
                    return true;
                }
                
            }
            return false;*/
            
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
            }

            if ((num == 2) || (num == 3))
            {
                isPrime = true;
            }

            if (num == 1)
            {
                isPrime = false;
            }
            return isPrime;
           
            /*for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    return true;
                }
                if ((num % 2 ==0) || (num % 3 == 0))
                { 
                    return false;
                }
            }
            return false;*/
            //My first attempt.
            
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;

            bool unique;

            for (int i = 0; i < str.Length; i++)
            {
                unique = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        unique = false;
                    }
                }

                if (unique == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();
            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }

            for (var i = n - 1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }

            return nthElement.ToArray();
        }
    }
}
