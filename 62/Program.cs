// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;

Clear();

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



int m = 4;
int n = 4;
int count = 1;
 

int [,] array = GetArray(4,4,10);

PrintArray(array);
WriteLine();

for (int y = 0; y < n; y++) 
{
    array[0,y] = count;
    count+=1;
}
for (int x = 1; x < m; x++) 
{
    array[x, n - 1] = count;
    count+=1;
}
for (int y = n - 2; y >= 0; y--) 
{
    array[m - 1,y] = count;
    count+=1;
}
for (int x = m - 2; x > 0; x--) 
{
    array[x,0] = count;
    count+=1;
}


array[1,1] = count;
count+=1;
array[1,2] = count;
count+=1;
array[2,2] = count;
count+=1;
array[2,1] = count;

PrintArray(array);
WriteLine();
