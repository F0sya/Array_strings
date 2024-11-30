﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

class Program
{

    


    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        bool checker = true;

        for (int i = 0; i < sentence.Length; i++)
        {

            if (checker == true && char.IsAsciiLetter(sentence[i]))
            {
                result.Append(char.ToUpper(sentence[i]));
                checker = false;
            }
            else
            {
                result.Append(sentence[i]);
            }

            if (sentence[i] == '.' || sentence[i] == '?' || sentence[i] == '!')
            {
                checker = true;
            }

        }
        



        Console.WriteLine($"Result:\n{result.ToString()}");
        
    }
}