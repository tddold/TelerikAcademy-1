﻿
//Write a program that enters from the console a positive integer n and prints all
//the numbers from 1 to n, on a single line, separated by a space.

using System;

namespace NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main()
        {
            Console.Write("Enter N: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
