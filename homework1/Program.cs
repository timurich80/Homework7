/* 
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 
*/

// void Fill2DArray(int[,] arr)

// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j< arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(1,10);
//         }
     
//     }
    
// }
// void PrintArr(int[,] arr) 
// {
//     for (int i = 0; i<arr.GetLength(0); i++)
//     {
//         for(int j = 0; j< arr.GetLength(1); j++)
//         {
//             Console.Write($"-{arr[i,j]}-");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] array2D = new int[5, 5];
// Fill2DArray(array2D); 
// PrintArr(array2D);


/* 
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет 
*/

//  Console.Write("Введите индекс строки: ");
//  int rows = Convert.ToInt32(Console.ReadLine());

//  Console.Write("Введите индекс столбца: ");
//  int colums = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[5, 5];
// FillArray2D(numbers);
// PrintArray2D(numbers);

// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
// else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }



/* 
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
*/


int[,] array2D = new int[4, 5];
Fill2DArray(array2D); 
PrintArr(array2D);
void Fill2DArray(int[,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j< arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
     
    }
    
}
void PrintArr(int[,] arr) 
{
    for (int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j< arr.GetLength(1); j++)
        {
            Console.Write($"-{arr[i,j]}-");
        }
        Console.WriteLine();
    }
}
 
double[] avgNumbers = new double[array2D.GetLength(1)];
double result = 0.0;
for (int i = 0; i < array2D.GetLength(1); i++)
{
    for (int j = 0; j < array2D.GetLength(0); j++)
    {
        result += array2D[j, i];
        
    }
    avgNumbers[i] = result / array2D.GetLength(0);
    System.Console.Write(avgNumbers[i] + " ");
}






