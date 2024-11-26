﻿using System;
using System.Collections.Generic;

class Program
{


    static void printMatrix(int[,] matrix)
    {

        for (int i = 0; i < matrix.GetLength(0); i++) // Rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // Columns
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void fillMatrix(int[,] matrix)
    {
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++) // Rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // Columns
            {
                matrix[i, j] = random.Next(-100, 101);
            }
        }
    }
    static int[] findMaxPos(int[,] matrix)
    {
        int max = matrix[0, 0];
        int[] list = new int[2];
        for (int i = 0; i < matrix.GetLength(0); i++) // Rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // Columns
            {
                if (matrix[i,j] > max)
                {
                    max = matrix[i,j];
                    list = [i, j];
                }
            }
        }
        return list;
    }

    static int[] findMinPos(int[,] matrix)
    {
        int min = matrix[0, 0];
        int[] list = new int[2];
        for (int i = 0; i < matrix.GetLength(0); i++) // Rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // Columns
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i,j];
                    list = [i, j];
                }
            }
        }
        return list;
    }

    static int findSum(int[,] matrix, int[] max_pos, int[] min_pos)
    {
        int sum = 0;
        int[] start_pos = new int[2];
        int[] end_pos = new int[2];
        if (max_pos[0] < min_pos[0])
        {
            start_pos = max_pos;
            end_pos = min_pos;
        }
        else if (max_pos[0] == min_pos[0])
        {
            if (max_pos[1] < min_pos[1])
            {
                start_pos = max_pos;
                end_pos = min_pos;
            }
            else
            {
                start_pos = min_pos;
                end_pos = max_pos;
            }
        }
        else { start_pos = min_pos; end_pos = max_pos; }

        sum += matrix[start_pos[0],start_pos[1]];
        bool check = false;
        for (int i = 0; i < matrix.GetLength(0); i++) // Rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // Columns
            {
                if ((i == start_pos[0] && j == start_pos[1]) || (i == end_pos[0] && j == end_pos[1])) {
                    if (check)
                    {
                        sum += matrix[i, j];
                        check = false;
                    }
                    else { check = true; }
                }
                else if (check) { sum += matrix[i, j]; }
            }
        }
        return sum;
    }

    static void Main()
    {
        int[,] matrix = new int[5, 5];

        fillMatrix(matrix);
        printMatrix(matrix);

        int[] max_pos = findMaxPos(matrix); //max_pos[0] - y cord, max_pos[1] - x cord;
        int[] min_pos = findMinPos(matrix); //min_pos[0] - y cord, min_pos[1] - x cord;



        Console.WriteLine($"Max pos: {max_pos[0]},{max_pos[1]}");
        Console.WriteLine($"Min pos: {min_pos[0]},{min_pos[1]}");

        Console.WriteLine($"Result:\n{findSum(matrix, max_pos, min_pos)}");

    }
}