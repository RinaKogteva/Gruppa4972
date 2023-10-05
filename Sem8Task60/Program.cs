// ДЗ Задача 60. Сформируйте трёхмерный массив. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int SetNumber(string message)
{
    Console.Write($"{message}");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[,,] GetMatrix(int height, int width, int depth, int min, int max)
{
    int [,,] matrix = new int[height, width, depth];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int l = 0; l < depth; l++)
                matrix[i, j, l] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
                Console.Write($"{matrix[i, j, l]}({j},{l},{i})\t");
            Console.WriteLine();
        }
        Console.WriteLine(); 
    }
}

int height = SetNumber("Введите высоту массива: ");
int width = SetNumber("Введите ширину массива: ");
int depth = SetNumber("Введите глубину массива: ");
int[,,] matrix = GetMatrix(height, width, depth, 1, 10);
Console.WriteLine();
PrintMatrix(matrix);
