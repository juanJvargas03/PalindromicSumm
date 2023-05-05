using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 1; i <= 1000000; i++)
        {
            if (IsPalindromic(i, 10) && IsPalindromic(i, 2))
            {
                Console.WriteLine(i + " is a palindromic number");
                Console.WriteLine("and in base 2 is also a palindrome " + Convert.ToString(i, 2));
                sum += i;
            }
        }
        Console.WriteLine("The sum of all palindromic numbers in base 10 and binary up to one million is: " + sum);
        Console.ReadLine();
    }

    static bool IsPalindromic(int number, int baseNumber)
    {
        string numberString = Convert.ToString(number, baseNumber);
        int length = numberString.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (numberString[i] != numberString[length - i - 1])
            {
                return false;
            }
        }
        
        return true;
    }
}
