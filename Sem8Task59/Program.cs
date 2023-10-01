﻿// // Печать двумерного массива
// void Print2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // Заполняем массив случайными числами
// void Fill2DArray(int[,] matr, int min, int max)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(min, max + 1);
//         }
//     }
// }

// void FindMin(int[,] arr, ref int x, ref int y)
// {
//     int min = arr[0, 0];
//     x = 0; y = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (min > arr[i, j])
//             {
//                 min = arr[i, j];
//                 x = i;
//                 y = j;
//             }
//         }
//     }
// }

// int[,] CreateArr(int[,] arr, int x, int y)
// {
//     int k = 0; int m = 0;
//     int[,] outArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         if (i == x)
//         {
//         }
//         else
//         {
//             m = 0;
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 if (j == y)
//                 {
//                 }
//                 else
//                 {
//                     outArr[k, m] = arr[i, j];
//                     m++;
//                 }
//             }
//             k++;
//         }
//     }
//     return outArr;
// }

// int[,] array2D = new int[4, 4];
// Fill2DArray(array2D, 0, 9);
// Print2DArray(array2D);
// int x = -1;
// int y = -1;
// FindMin(array2D, ref x, ref y);
// int[,] outArr = CreateArr(array2D, x, y);
// Print2DArray(outArr);


//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 59                                     
//   Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
//   пересечении которых расположен наименьший элемент массива.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
// Ввод парметров матрицы.
int countRow = ReadInt("Введите количество строк m: ");
int countCol = ReadInt("Введите количество cтолбцов n: ");

// Генерация и вывод матрицы.
int minValue = -10;
int maxValue = 10;
int[,] matrix = CreateRandomMatrix(countRow, countCol, minValue, maxValue);
PrintMatrix("Заданная матрица", matrix);

// Поиск индексов минимального элемента
(int smallestValue, int colIndex, int rowIndex) min = FindMinElement(matrix);
Console.WriteLine ($"Наименьший элемент: {min.smallestValue} позиция [{min.rowIndex},{min.colIndex}]");

// Удаление строки и столбца на пересечении элемента, который наименьший в массиве и вывод нового массива
int[,] resultMatrix = RemoveRowAndColumn(matrix, min.rowIndex, min.colIndex);
PrintMatrix("Измененная матрица", resultMatrix);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генераци двумерного массива, заполненного случайными целыми значениями.
int[,] CreateRandomMatrix(int countRow, int countCol, int minValue, int maxValue)
{
    Random random = new Random();
    int[,] matrix = new int[countRow, countCol];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

// Вывод двумерного массива на экран.
void PrintMatrix(string msg, int[,] matrix)
{
    Console.WriteLine("\n" + msg);

    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

// Поиск наименьшего элемента в массиве и его индекса
(int smallestValue,  int colIndex, int rowIndex) FindMinElement(int[,] matrix)
{
    int smallestValue = int.MaxValue;
    int rowIndex = -1;
    int colIndex = -1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < smallestValue)
            {
                smallestValue = matrix[i, j];
                rowIndex = i;
                colIndex = j;
            }
        }
    }
    return (smallestValue, rowIndex, colIndex);
}

// Удаление строки и столбца из двумерного массива
int[,] RemoveRowAndColumn(int[,] matrix, int rowIndex, int colIndex)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    int[,] resultMatrix = new int[rowCount - 1, colCount - 1];

    for (int i = 0, newRow = 0; i < rowCount; i++)
    {
        if (i == rowIndex) continue; // Если индекс строки равен индексу минимального, его пропускаем

        for (int j = 0, newCol = 0; j < colCount; j++)
        {
            if (j == colIndex) continue; // Если индекс столбца равен индексу минимального, его пропускаем

            resultMatrix[newRow, newCol] = matrix[i, j];
            newCol++;
        }
        newRow++;
    }

    return resultMatrix;
}