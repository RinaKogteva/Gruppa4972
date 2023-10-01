﻿﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}

// Заполняет массив случайными цифрами
void FillingArray(int[,] array)
{
    // количество свободных ячеек
    int cellsByX = array.GetLength(1); // по Х
    int cellsByY = array.GetLength(0); // по Y
    // Переменные определяют направление
    bool isDown = true; // true - заполняет вниз, false - заполняет вверх
    bool isRight = true; // true - заполняет вправо, false - заполняет влево

    int currentNumber = 0;
    int currentX = -1;
    int currentY = 0;

    while (cellsByX != 0 || cellsByY != 0)
    {
        //// ---------------------------------------------------Движение вправо/влево--------------------------------------------------------------------////

        int startCell;
        int finishCell;

        // Если есть свободные ячейки по Y
        if (cellsByY != 0)
        {
            int currentRow = currentY;

            // Вычисление стартовой и финишной переменных
            // Если движемся вправо
            if (isRight)
            {
                finishCell = array.GetLength(1) - (array.GetLength(1) - cellsByX) / 2;
                startCell = currentX + 1;
            }
            else // Если движемся влево
            {
                finishCell = (array.GetLength(1) - cellsByX) / 2 - 1;
                startCell = currentX - 1;
            }

            // Перебор ячеек в текущей строчке, в зависимости от isRight определяются границы выполнения for
            for (int i = startCell; isRight ? i < finishCell : i > finishCell;)
            {
                array[currentRow, i] = currentNumber;
                currentNumber++;

                currentX = i;

                i = isRight ? i + 1 : i - 1;
            }

            cellsByY--;
            isRight = !isRight; // Изменение направления
        }

        //// ---------------------------------------------------Движение вверх/вниз--------------------------------------------------------------------////

        // Если есть свободные ячейки по X
        if (cellsByX != 0)
        {
            int currentColumn = currentX;

            // Вычисление стартовой и финишной переменных
            // Если движемся вниз
            if (isDown)
            {
                finishCell = array.GetLength(0) - (array.GetLength(0) - cellsByY) / 2;
                startCell = currentY + 1;
            }
            else // Если движемся вверх
            {
                finishCell = array.GetLength(0) - currentY - 1;
                startCell = currentY - 1;
            }

            // Перебор ячеек в текущей строчке, в зависимости от isDown определяются границы выполнения for
            for (int i = startCell; isDown ? i < finishCell : i > finishCell;)
            {
                array[i, currentColumn] = currentNumber;
                currentNumber++;

                currentY = i;

                i = isDown ? i + 1 : i - 1;
            }

            cellsByX--;

            isDown = !isDown; // Изменение направления
        }
    }
}
// Выводит элементы массива в консоль
void Output2DArray(int[,] array, string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            Console.Write(array[i, j] + ",\t ");
        }

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
    }
}

//Антон
// Создаем спиральный массив
int[,] GenerateSpiralArray(int n)
{
    int[,] spiral = new int[n, n];
    int num = 1;
    int rowStart = 0;
    int rowEnd = n - 1;
    int colStart = 0;
    int colEnd = n - 1;

    while (num <= n * n)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            spiral[rowStart, i] = num++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            spiral[i, colEnd] = num++;
        }
        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
        {
            spiral[rowEnd, i] = num++;
        }
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            spiral[i, colStart] = num++;
        }
        colStart++;
    }

    return spiral;
}

//Татьяна
// Заполняем двумерный массив спирально
int[,] FillSpiralArray(int rows, int columns)//, int topBorder, int downBorder
{
    int[,] array = new int[rows, columns];
    int value = 1;
    
    // Границы массива
    int left = 0, right = columns - 1, top = 0, bottom = rows - 1; 
    
    // Пока не заполнены все ячейки
    while (value <= rows * columns)
    {
        // Заполняем верхнюю строку слева направо
        for (int i = left; i <= right && value <= rows * columns; i++)
        {
            array[top, i] = value;
            value++;
        }
        top++;

        // Заполняем правый столбец сверху вниз
        for (int i = top; i <= bottom && value <= rows * columns; i++)
        {
            array[i, right] = value;
            value++;
        }
        right--;

        // Заполняем нижнюю строку справа налево
        for (int i = right; i >= left && value <= rows * columns; i--)
        {
            array[bottom, i] = value;
            value++;
        }
        bottom--;

        // Заполняем левый столбец снизу вверх
        for (int i = bottom; i >= top && value <= rows * columns; i--)
        {
            array[i, left] = value;
            value++;
        }
        left++;
    }
    
    return array;
}


int[,] FillSpiral(int[,] matrix, int startNumber = 1, int count = 1)
{
    for (int j = -1 + count; j < matrix.GetLength(1) + 1 - count; j++)
    {
        matrix[-1 + count, j] = startNumber++;
    }
    for (int i = count; i < matrix.GetLength(0) + 1 - count; i++)
    {
        matrix[i, matrix.GetLength(1) - count] = startNumber++;
    }
    for (int j = matrix.GetLength(1) - 1 - count; j > -1 + count; j--)
    {
        matrix[matrix.GetLength(0) - count, j] = startNumber++;
    }
    for (int i = matrix.GetLength(0) - count; i > -1 + count; i--)
    {
        matrix[i, -1 + count] = startNumber++;
    }
    if (startNumber <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        FillSpiral(matrix, startNumber, ++count);
    }
    return matrix;
}




// Метод, принимает строку, выводит в консоль
static void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Получение данных от пользователя
int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");

//int[,] array0 = FillSpiral(new int[m, n]);
//Output2DArray(array0, "Массив: ");

// Создание, заполнение и вывод массива
DateTime d1 = DateTime.Now;
int[,] array1 = new int[m, n];
FillingArray(array1);
//Output2DArray(array1, "Массив: ");
PrintResult("Решение Анастасии: " + (DateTime.Now - d1));

Console.WriteLine();

DateTime d2 = DateTime.Now;
int[,] array2 = GenerateSpiralArray(n);
//Output2DArray(array2, "Массив: ");
PrintResult("Решение Антона: " + (DateTime.Now - d2));

Console.WriteLine();

DateTime d3 = DateTime.Now;
int[,] array3 = FillSpiralArray(n,m);
//Output2DArray(array3, "Массив: ");
PrintResult("Решение Татьяна: " + (DateTime.Now - d3));

Console.WriteLine();

DateTime d4 = DateTime.Now;
int[,] array0 = FillSpiral(new int[m, n]);
//Output2DArray(array3, "Массив: ");
PrintResult("Решение Рекурентное: " + (DateTime.Now - d4));