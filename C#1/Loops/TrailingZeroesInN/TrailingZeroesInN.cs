﻿
//Problem 18.* Trailing Zeroes in N!

//    Write a program that calculates with how many zeroes the
//factorial of a given number n has at its end.
//    Your program should work well for very big numbers,
//e.g. n=100000.


using System;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int countZero = 0;
        int divider = 5;
        while (n / divider >= 1)
        {
            countZero += n / divider;
            divider *= 5;
        }
        Console.WriteLine("{0}! has {1} trailing zeros"
        , n, countZero);
    }
}

