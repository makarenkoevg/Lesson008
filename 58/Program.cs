// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;

Clear();


int GetCount(int x, int y, int[,] arr1, int[,] arr2)// вычисляет произведение строки x массива arr1 на солбец y массива arr2
    {
        int count = 0;
        for (int i=0; i<arr1.GetLength(1);i++)
        {
            count+=arr1[x,i]*arr2[i,y];
        }
        return count;
    }

int[,]  MultyMatrix(int [,] arrayOne, int[,] arrayTwo)// Метод возвращает матрицу, являющуюся произведением двух матриц
{
    int l = arrayOne.GetLength(0);
    int n = arrayTwo.GetLength(1);

    int[,] array = new int[l,n];

    for(int i=0; i<arrayOne.GetLength(0); i++)
    {
        for(int j=0; j<arrayTwo.GetLength(1); j++)
        {
            array[i,j] = GetCount(i,j,arrayOne,arrayTwo);
        }
    }
    return array;

}

int [,] GetArray(int m, int n, int max)
{
    int [,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(max);
          
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




// void PrintArrayy(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
      
//             Write($"{array[i]:f2} ");

//     }
// }

Write("Введите количество строк массива #1: ");
int rows1 = int.Parse(ReadLine());

Write("Введите количество столбцов массива #1: ");
int columns1 = int.Parse(ReadLine());

Write("Введите количество строк массива #2: ");
int rows2 = int.Parse(ReadLine());

Write("Введите количество столбцов массива #2: ");
int columns2 = int.Parse(ReadLine());


int [,] workArray1 = GetArray(rows1,columns1,10);
int [,] workArray2 = GetArray(rows2,columns2,10);

PrintArray(workArray1);
WriteLine();

PrintArray(workArray2);
WriteLine();


if (workArray1.GetLength(1) != workArray2.GetLength(0))
{
    WriteLine("Эти матрицы перемножить невозможно");
}
else
{
    PrintArray(MultyMatrix(workArray1,workArray2));
}