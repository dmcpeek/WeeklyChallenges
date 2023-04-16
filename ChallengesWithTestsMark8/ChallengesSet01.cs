using System;
using System.ComponentModel.Design;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public static bool AreTwoNumbersTheSame(int num1, int num2)
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

        public static double Subtract(double minuend, double subtrahend)
        {

            return (minuend - subtrahend);
            //throw new NotImplementedException();
        }

        public static int Add(int number1, int number2)
        {
            return (number1 + number2);
            //throw new NotImplementedException();
        }

        public static int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
                return number1;
            else
                return number2;
            //throw new NotImplementedException();
        }

        public static long Multiply(long factor1, long factor2)
        {
            return (factor1 * factor2);
            //throw new NotImplementedException();
        }

        public static string GetGreeting(string nameOfPerson)
        {
            return ($"Afternoon {nameOfPerson}. How's your family doin'?");
            //throw new NotImplementedException();
        }

        public static string GetHey()
        {
            return ($"How many ways can you spell hey? Did you think of hay and hae?"); ;
            //throw new NotImplementedException();
        }
    }
}
