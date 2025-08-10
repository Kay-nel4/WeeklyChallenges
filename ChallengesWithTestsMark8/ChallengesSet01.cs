using System;
using System.ComponentModel.Design;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double remainder = minuend - subtrahend;
            return remainder;
        }

        public int Add(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }    
        }

        public long Multiply(long factor1, long factor2)
        {
            long answer = factor1 * factor2;
            return answer;
        }

        public string GetGreeting(string nameOfPerson)
        {
            
            if (string.IsNullOrEmpty(nameOfPerson))
            {
                return ("Hello!");
            }
            
            return ($"Hello, {nameOfPerson}!");
        



        }

        public string GetHey()
        {
            string greeting = "HEY!";
            return greeting;
        }
    }
}
