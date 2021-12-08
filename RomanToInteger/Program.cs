using System;

namespace RomanToInteger
{
    class Solution
    {
        
        public static int ConvertChar(char letter)     //converts a given letter to an int
        {
            int number = 0;
            if (letter == 'I')
            {
                number = 1;
            }
            else if (letter == 'V')
            {
                number = 5;
            }
            else if (letter == 'X')
            {
                number = 10;
            }
            else if (letter == 'L')
            {
                number = 50;
            }
            else if (letter == 'C')
            {
                number = 100;
            }
            else if (letter == 'D')
            {
                number = 500;
            }
            else if (letter == 'M')
            {
                number = 1000;
            }
            else
            {
                Console.WriteLine("Improper Roman Number!");
                return 0;
            }
            return number;
        }

        public static int RomanToInt(string s)
    {
        int sum = 0;
        int subSum = 0;
        int i = 0;

        char[] charArr = s.ToCharArray();   //convert the string s to an array of chars
        while (i < charArr.Length)
            {
                ConvertChar(charArr[i]);

                if (charArr[i] == 'I' && charArr[i+1] == 'V')
                {
                    subSum = 4;
                    sum = sum + subSum;
                    i++;
                }
                else if(charArr[i] == 'I' && charArr[i + 1] == 'X')
                {
                    subSum = 9;
                    sum = sum + subSum;
                    i++;
                }
                else if(charArr[i] == 'X' && charArr[i + 1] == 'L')
                {
                    subSum = 40;
                    sum = sum + subSum;
                    i++;
                }
                else if(charArr[i] == 'X' && charArr[i + 1] == 'C')
                {
                    subSum = 90;
                    sum = sum + subSum;
                    i++;
                }
                else if(charArr[i] == 'C' && charArr[i + 1] == 'D')
                {
                    subSum = 400;
                    sum = sum + subSum;
                    i++;
                }
                else if(charArr[i] == 'C' && charArr[i + 1] == 'M')
                {
                    subSum = 900;
                    sum = sum + subSum;
                    i++;
                }
                else
                {
                    sum = sum + ConvertChar(charArr[i]);
                }
                i++;
            }
        return sum;
    }
        static void Main(string[] args)
        {
            string romanNumber = Console.ReadLine();
            //RomanToInt(romanNumber);
            Console.WriteLine(RomanToInt(romanNumber));
        }
    }
}
