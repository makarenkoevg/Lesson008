// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

double[,] SortArray(double[,] array, int line)// Сортирует по убыванию строку с индексом line массива array
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
    
        for (int j = 0; j < array.GetLength(1) - 1 - i; j++)
        {
            if (array[line,j] < array[line,j + 1])
            {
                double temp = array[line,j];
                array[line,j] = array[line,j+1];
                array[line,j+1] = temp;
            }
        }
    }
    return array;
}

double [,] workArray = GetArray(rows,columns,-10,10);

PrintArray(workArray);
WriteLine();

for (int i = 0; i<workArray.GetLength(0);i++)
{
    workArray = SortArray(workArray, i);
}

PrintArray(workArray);