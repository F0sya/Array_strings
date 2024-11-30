﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{

    

    static int solution(string problem)
    {
        int[] arr = { };
        char[] operations = { };
        for(int i= 0; i < problem.Length; i++)
        {
            if (problem[i] == '+' || problem[i] == '-')
            {
                operations = operations.Append<char>(problem[i]).ToArray();
            }
            else if (Char.IsDigit(problem[i]) == true)
            {
                arr = arr.Append<int>(problem[i] - 48).ToArray();
                
            }
        }
        int result = arr[0];
        for (int i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case '+':
                    result += arr[i + 1];
                    break;
                case '-':
                    result -= arr[i + 1];
                    break;

            }
        }

        return result;
        

    }

    static void Main()
    {
        Console.WriteLine("Enter an math problem:");
        string problem = Console.ReadLine();

        int output = solution(problem);
        Console.WriteLine($"Result: {output}");
    }
}