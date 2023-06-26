/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

using System;
using static System.Console;
Clear();
WriteLine("Enter rows: ");
int rows = Convert.ToInt32(ReadLine());
WriteLine("Enter columns: ");
int columns = Convert.ToInt32(ReadLine());
int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
WriteLine();
GetOrderingArray(array);


int[,] GetArray(int r, int c, int min, int max)
{
    int[,] resulte = new int [r,c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            resulte[i,j] =  new Random().Next(min, max+1);
        }
    }
    return resulte;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

void GetOrderingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int ord = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = ord;
                }
            }
            Write(array[i,j]+" ");
        }
        WriteLine();
    }
    
}