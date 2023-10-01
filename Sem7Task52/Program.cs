﻿// // №52 Задайте двумерный массив из целых чисел. 
// // Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// // * Дополнительно вывести среднее арифметическое по диагоналям 
// // и диагональ выделить разным цветом.

// int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// // Заполнение случайными числами
// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     int[,] array2D = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
//         }
//     }
//     return array2D;
// }
// // вывод матрицы с цветным и диаганалями
// void PrintArray (int [,] matrix)
//     {
    
//     ConsoleColor mainDiagColor = ConsoleColor.Yellow;
//     ConsoleColor secondDiagColor = ConsoleColor.DarkBlue;
//     ConsoleColor defaultColor = ConsoleColor.Gray;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.ForegroundColor = 
//             (i == j)? mainDiagColor:
//             (i+j == matrix.GetLength(1)-1)?secondDiagColor: 
//             defaultColor;
//             Console.Write(matrix[i,j]+"\t");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }
//   // Печать средних по столбцам
//   void  PrintListAvr (double [] list)
//     {
//       Console.WriteLine("The averages in columns are: ");
//       for(int i = 0; i < list.Length; i++)
//         Console.Write(list[i].ToString("0.00")+"\t");
    
//         Console.WriteLine();    
//     }
//   // Поиск средних по столбцам
//   double [] FindAverageInColumns (int [,] matrix)
//     { 
//       double[] result = new double[matrix.GetLength(1)];
//       for(int j = 0; j < matrix.GetLength(1); j++)
//       {
//         result[j] = 0;
//         for(int i = 0; i < matrix.GetLength(0); i++)
//         {
//           result[j] +=matrix[i,j];
//         }
//         result[j]/=matrix.GetLength(0);
//       }
//       return result;
//     }
// //Поисх средних по диаганалями
// double[] AveragesInDiaganals(int [,] matrix)
// {

//     double[] result = {0,0};
//     int numVal = matrix.GetLength(1) < matrix.GetLength(0) ? matrix.GetLength(1): matrix.GetLength(0);
//     for(int j = 0; j < matrix.GetLength(1); j++) // пробегаем по диаганалям
//     {
//          if(j < numVal) 
//            result[0] += matrix[j,j]; // накладываем условия, чтобы не вылезти за границы
//          if(matrix.GetLength(0) > matrix.GetLength(1)-1-j) // накладываем условия, чтобы не вылезти за границы
//             result[1] += matrix[matrix.GetLength(1)-1-j, j]; 
//     }
//     result[0]/=numVal;
//     result[1]/=numVal;
//     return result;
// }
// //печать средних по диаганалям
//  void  PrintDiagAverages (double [] diagAvg)
//     {
//         Console.WriteLine($"Среднее на главной диаганали: {diagAvg[0].ToString("0.00")}, а среднее по побочной: {diagAvg[1].ToString("0.00")}");
//     }
   
   
//    Console.Clear();
// int n = ReadData("Введите количество строк");
// int m = ReadData("Введите количество стобцов");
// int[,] arr2D = Fill2DArray(n,m,10,-10);
// PrintArray(arr2D);
// double[] avgArr = FindAverageInColumns(arr2D);
// PrintListAvr(avgArr);
// double[] avgDiag = AveragesInDiaganals(arr2D);
// PrintDiagAverages(avgDiag);

﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}
// Заполняет массив случайными цифрами
void IntRandom2DArray(int[,] array, int minElement, int maxElement)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minElement, maxElement + 1);
}
// Выводит элементы массива в консоль
void Output2DArray(int[,] array, string message)
{
    Console.WriteLine(message);

    // Массив с цветами консоли
    ConsoleColor[] newColors = NewColorsArray( array.GetLength(1) + array.GetLength(0) - 1);

    // Вывод элементов
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            Console.ForegroundColor = newColors[i + j];
            Console.Write(array[i, j]);
            Console.ResetColor();
            Console.Write(", ");
        }

        Console.ForegroundColor = newColors[i + array.GetLength(1) - 1];
        Console.Write(array[i, array.GetLength(1) - 1]);
        Console.ResetColor();

        Console.Write("}\n");
    }

    Console.ResetColor();

    FindAverage(newColors, array);
}
// Рандомно задаёт цвета диагоналям
ConsoleColor[] NewColorsArray(int length)
{
    // Массив со всеми цветами консоли
    ConsoleColor[] colors = { ConsoleColor.Gray, ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Cyan,
                            ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.Blue, ConsoleColor.DarkGreen,
                            ConsoleColor.DarkBlue, ConsoleColor.Yellow, ConsoleColor.White, ConsoleColor.Green,
                            ConsoleColor.DarkYellow, ConsoleColor.DarkRed, ConsoleColor.DarkMagenta };

    // Новый массив цветов консоли, подстроенный под количество  диагоналей 
    ConsoleColor[] newColors = new ConsoleColor[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        newColors[i] = colors[rnd.Next(0, colors.Length)];
    }

    return newColors;
}
// Ищет ср знач и передаёт его в метод печати
void FindAverage(ConsoleColor[] newColors, int[,] array)
{
    // Средние значения в диагоналях 
    double[] averageValues = new double[newColors.Length];

    for (int i = 0; i < newColors.Length; i++)
    {
        int sum = 0;
        int count = 0;

        int m = i < array.GetLength(1) ? i : array.GetLength(1) - 1;
        int n = i < array.GetLength(1) ? 0 : i - array.GetLength(1) + 1;
        while (m >= 0 && n < array.GetLength(0))
        {
            sum += array[n, m];
            count++;
            m--;
            n++;
        }

        averageValues[i] = (double)sum/count;
    }

    AverageValuesOutput(newColors, averageValues);
}
// Выводит массив со средними значениями
void AverageValuesOutput(ConsoleColor[] newColors, double[] averageValues)
{
    Console.WriteLine();
    Console.WriteLine("Средние значения:");

    for (int i = 0; i < newColors.Length - 1; i++)
    {
        Console.ForegroundColor = newColors[i];
        Console.Write(averageValues[i].ToString("0.00") + ", ");
        Console.ResetColor();
    }

    // Вывод последнего элемента
    Console.ForegroundColor = newColors[newColors.Length - 1];
    Console.Write(averageValues[newColors.Length - 1].ToString("0.00") + ".");
    Console.ResetColor();
}

// Смена параметров локализации для точки в вещественных числах
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");
int minElement = 0;
int maxElement = 9;

int[,] array = new int[m, n];
IntRandom2DArray(array, minElement, maxElement);
Output2DArray(array, "Массив: ");