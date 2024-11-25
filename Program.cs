﻿using System;

class Program
{


    static void printMatrix(int[] A)
    {
        Console.WriteLine("\nArray A:");
        foreach (int num in A)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static int FindMax(int[] A, int[,] B)
    {
        int max = A[0];
        foreach (int num in A)
        {
            if (num > max) max = num;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max) max = B[i, j];
            }
        }
        return max;
    }

    static int FindMin(int[] A, int[,] B)
    {
        int min = A[0];
        foreach (int num in A)
        {
            if (num < min) min = num;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] < min) min = B[i, j];
            }
        }
        return min;
    }

    static int CalculateSum(int[] A, int[,] B)
    {
        int sum = 0;
        foreach (int num in A)
        {
            sum += num;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                sum += B[i, j];
            }
        }
        return sum;
    }

    static long Multiply(int[] A, int[,] B)
    {
        long multiply = 1;
        foreach (int num in A)
        {
            multiply *= num;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                multiply *= B[i, j];
            }
        }
        return multiply;
    }

    static int CalculateSumEven(int[] A)
    {
        int sumEvenA = 0;
        foreach (int num in A)
        {
            if (num % 2 == 0) sumEvenA += num;
        }
        return sumEvenA;
    }

    static int CalculateSumOddColumns(int[,] B)
    {
        int sumOddColumnsB = 0;
        for (int j = 1; j < B.GetLength(1); j += 2)
        {
            for (int i = 0; i < B.GetLength(0); i++)
            {
                sumOddColumnsB += B[i, j];
            }
        }
        return sumOddColumnsB;
    }

    static void Main()
    {
        int[] A = new int[5];
        int[,] B = new int[3, 4];

        Random rand = new Random();


        Console.WriteLine("Enter 5 integers for array A:");
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                B[i, j] = rand.Next(100);
            }
        }

        printMatrix(A);
        Console.WriteLine("\nArray B:");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write($"{B[i, j]} ");
            }
            Console.WriteLine();
        }

        int max = FindMax(A, B);
        int min = FindMin(A, B);
        int sum = CalculateSum(A, B);
        long multiply = Multiply(A, B);
        int sumEvenA = CalculateSumEven(A);
        int sumOddColumnsB = CalculateSumOddColumns(B);

        Console.WriteLine($"\nMaximum element: {max}");
        Console.WriteLine($"Minimum element: {min}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Multiply: {multiply}");
        Console.WriteLine($"Sum of even elements: {sumEvenA}");
        Console.WriteLine($"Sum of odd columns: {sumOddColumnsB}");
    }
}