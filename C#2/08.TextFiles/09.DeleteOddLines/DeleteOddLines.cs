﻿
//Problem 9. Delete odd lines

//    Write a program that deletes from given text file all odd lines.
//    The result should be in the same file.


using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main(string[] args)
    {
        string FilPath = @"..\..\text.txt";
        List<string> text = GetEvenLine(FilPath);
        WriteTextToFile(FilPath, text);
    }

    private static List<string> GetEvenLine(string FilPath)
    {
        List<string> result = new List<string>();
        int countLine = 0;
        using (StreamReader streamReader = new StreamReader(FilPath))
        {
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                if (countLine % 2 == 0)
                {
                    result.Add(line);
                }
                countLine++;
            }

        }
        return result;
    }

    private static void WriteTextToFile(string FilPath, List<string> text)
    {
        using (StreamWriter streamWriter = new StreamWriter(FilPath))
        {
            foreach (var line in text)
            {
                streamWriter.WriteLine(line);
            }
        }
    }
}


