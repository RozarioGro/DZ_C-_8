/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


Console.Clear();
Console.Write("Enter rows: ");
int roes = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter columns: ");
int columns = Convert.ToInt16(Console.ReadLine());
int[,] array = GetArray(roes, columns, 1, 10);
PrintArray(array);
GetMinRows(array);

int[,] GetArray(int r, int c, int min, int max)
{
    int[,] resulte = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            resulte[i, j] = new Random().Next(min, max + 1);
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void GetMinRows(int[,] array)
{
    int minSumRowIndex = 0;
    int minSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }

        if (rowSum < minSum || minSum == 0)
        {
            minSum = rowSum;
            minSumRowIndex = i;
        }

        Console.WriteLine($"Сумма элементов в строке {i} равна {rowSum}");
    }

    Console.WriteLine($"Строка с минимальной суммой элементов: {minSumRowIndex}, сумма элементов: {minSum}");


}



