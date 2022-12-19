// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных 
// чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



using System;
using static System.Console;

Clear();



bool NumberInArray(int[] array, int num, int ind)
{
    bool value = false;
    if (ind==0) {
        value = false;
    }
    else{
        for(int i = 0; i<ind; i++)
        {
            if (array[i]== num) 
            {
                value = true;
                return value;
            }
        }

    }
    return value;
    
}
int GetNumber (int min, int max)
{
    int number = 0;
    while (number<min)
    {
         number = new Random().Next(max+1);
    }
    return number;

}

int [,,] GetArray(int m, int n, int k, int min, int max)
{
    int [,,] result = new int[m, n, k];
    int [] checkArray = new int[m*n*k];
    int number = 0;
    int index = 0;
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int r = 0; r<k; r++)
            {
                number = GetNumber(10,99);
                while (NumberInArray(checkArray, number, index))
                {
                    number = GetNumber(10,99);
                }
                checkArray[index] = number;
                result[i, j, r] = number;
                index+=1;
              

            }
          
        }

    }
  
    return result;
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
}




// void PrintArrayy(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
      
//             Write($"{array[i]} ");

//     }
// }


Write("Введите x: ");
int x = int.Parse(ReadLine());

Write("Введите y: ");
int y = int.Parse(ReadLine());

Write("Введите z: ");
int z = int.Parse(ReadLine());

while ((x*y*z)>89)
{
    if ((x*y*z)>89)
    {
        WriteLine("Слишком большой размер!!!");

        
        Write("Введите x: ");
        x = int.Parse(ReadLine());

        Write("Введите y: ");
        y = int.Parse(ReadLine());

        Write("Введите z: ");
        z = int.Parse(ReadLine());

        WriteLine();
        

    }
}
int [,,] workArray = GetArray(x,y,z,10,99);

PrintArray(workArray);
WriteLine();

