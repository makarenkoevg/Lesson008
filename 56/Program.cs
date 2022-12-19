// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер с
// троки с наименьшей суммой элементов: 1 строка


using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());


double [,] GetArray(int m, int n, int min, int max)
{
    double [,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(max-min)+min;
          
        }

    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]:f2} ");
        }
        WriteLine();
    }
}

double [] SummString(double[,] array)
{
    double [] result = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+=array[i,j];    
        }
        result[i] = sum;
    }
    return result;
}

int MinIndex(double[] array)
{
    int minIndex = 0;
    for(int i=1; i<array.Length;i++)
    {
        if (array[i]<array[minIndex])
        {
            minIndex = i;
        }
    }
    return minIndex;
}



// void PrintArrayy(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
      
//             Write($"{array[i]:f2} ");

//     }
// }

double [,] workArray = GetArray(rows,columns,0,10);

PrintArray(workArray);
WriteLine();
// PrintArrayy(SummString(workArray));
// WriteLine();
Write($"Строка с наименьшей суммой элементов: {MinIndex(SummString(workArray))+1}");
