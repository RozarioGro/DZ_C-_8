/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.WriteLine(" Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintArray(GetArray(N));


int[,] GetArray(int n)
{
    int[,] matrix = new int[n, n];
    int num = 01; // начальное значение числа, которыми заполняется матрица
    int rowStart = 0; // начальная строка матрицы
    int rowEnd = n - 1; // конечная строка матрицы
    int colStart = 0; // начальный столбец матрицы
    int colEnd = n - 1; // конечный столбец матрицы

    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        // заполнение верхней строки
        for (int i = colStart; i <= colEnd; i++)
        {
            matrix[rowStart, i] = num;
            num++;
        }
        rowStart++;

        // заполнение правого столбца
        for (int i = rowStart; i <= rowEnd; i++)
        {
            matrix[i, colEnd] = num;
            num++;
        }
        colEnd--;

        // заполнение нижней строки
        if (rowStart <= rowEnd)
        {
            for (int i = colEnd; i >= colStart; i--)
            {
                matrix[rowEnd, i] = num;
                num++;
            }
            rowEnd--;
        }

        // заполнение левого столбца
        if (colStart <= colEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                matrix[i, colStart] = num;
                num++;
            }
            colStart++;
        }
    }
    return matrix;
}

void PrintArray(int[,]matrix)
{
    // вывод матрицы на экран
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,2:00 }", matrix[i, j]);
        }
        Console.WriteLine();
    }

}

