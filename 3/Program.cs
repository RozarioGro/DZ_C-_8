/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
using System;
using static System.Console;
Clear();
WriteLine("Enter rows: ");
int rows = Convert.ToInt32(ReadLine());
WriteLine("Enter columns: ");
int columns = Convert.ToInt32(ReadLine());
WriteLine("Enter L: ");
int K = Convert.ToInt32(ReadLine());
WriteLine("Enter columns: ");
int[,,] array = GetArray(rows, columns, K, 1, 10);
PrintArray(array);



int[,,] GetArray(int r, int c, int k, int min, int max)
{
    int[,,] resulte = new int [r,c,k];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
           for (int l = 0; l < k; l++)
           {
                resulte[i,j,l] =  new Random().Next(min, max+1);
           } 
        }
    }
    return resulte;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Write($"{array[i,j,l]}{(i,j,l)} ");
            }
            WriteLine();
        }
        
    }
}
