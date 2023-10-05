// ДЗ Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



int SetNumber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns, int minValue = 10, int maxValue = 99)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
            matrix[i, l] = rand.Next(minValue, maxValue + 1);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
            Console.Write($"{matrix[i, l]} ");
        Console.WriteLine();
    }
}

void FilterRows (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            for (int j = 0; j < matrix.GetLength(1); j++)
        {
                for (int l = 0; l < matrix.GetLength(1) - 1 - j; l++)
            {
                if (matrix[i, l] < matrix[i, l + 1])
                {
                    int temp = matrix[i, l];
                    matrix[i, l] = matrix[i, l + 1];
                    matrix[i, l + 1] = temp;
                } 
            }
        }
    }
}

int rows = SetNumber("m");
int columns = SetNumber("n");
int[,] array = GetMatrix(rows, columns, 0, 9);
PrintMatrix(array);
System.Console.WriteLine();
FilterRows(array);
PrintMatrix(array);
