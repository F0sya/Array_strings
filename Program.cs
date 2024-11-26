﻿using System;
using System.Collections.Generic;

class Program
{

    static string Decypher(string input, int d)
    {
        char[] result = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            if (Convert.ToInt32(input[i]) - d < 97)
            {
                result[i] = Convert.ToChar(123 - (122 - (Convert.ToInt32(input[i]) +(25- d))));
            }
            else
            {
                result[i] = Convert.ToChar(Convert.ToInt32(input[i]) - d);
            }
        }
        string res = new string(result);
        return res;
    }
    static string Cypher(string input,int d)
    {
        char[] result = new char[input.Length];
        for(int i =0;i < input.Length; i++)
        {
            if(Convert.ToInt32(input[i]) + d > 122)
            {
                result[i] = Convert.ToChar(96  + (Convert.ToInt32(input[i]) + d- 122));
            }
            else {
                result[i] = Convert.ToChar(Convert.ToInt32(input[i]) + d);
            }
        }
        string res = new string(result);
        return res;
    }

    static void Main()
    {
        Console.WriteLine("Enter a string:"); string str = Console.ReadLine().ToLower();
        Console.WriteLine($"Your string: '{str}'");
        Console.WriteLine("Enter a step:"); int step = Convert.ToInt32(Console.ReadLine());

        // a - 97 ;z - 122 Ifmmp!Xpsme

        Console.WriteLine($"Cyphred string: {Cypher(str,step)}");
        Console.WriteLine($"Decyphred string: {Decypher(str, step)}");
    }
}