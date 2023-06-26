/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
using System;
using static System.Console;
Clear();
Write("Enter rows A :");
int rowsA = Convert.ToInt32(ReadLine());
Write("Enter columns A :");
int columnsA = Convert.ToInt32(ReadLine());
Write("Enter rows B :");
int rowsB = Convert.ToInt32(ReadLine());
Write("Enter columns B :");
int columnsB = Convert.ToInt32(ReadLine());
int[,] A = GetMatrix(rowsA, columnsA, 1, 9);
int[,] B = GetMatrix(rowsB, columnsB, 1, 9);
PrintArray(A);
WriteLine();
PrintArray(B);
WriteLine();
PrintArray(MatrixSqr(A,B));


int[,] GetMatrix(int r, int c, int min, int max)
{
    int[,] result = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
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


int[,] MatrixSqr(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0))
    {
        WriteLine("Матрицы не умножаемы!!!");
    }

    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(1); k++)
            {
                result[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return result;
}
