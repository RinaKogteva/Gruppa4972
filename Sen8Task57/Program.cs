// Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine()??",";
//     int number = Convert.ToInt32(value);

//     return number;
// }
// // Заполняет массив случайными цифрами
// void IntRandom2DArray(int[,] array, int minElement, int maxElement)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(minElement, maxElement + 1);
// }
// // Ищет частоту появления чисел в массиве
// Dictionary<int, int> Frequency(int[,] array)
// {
//     // Частотный словарь (ключ - элемент массива, значение - количество таких же элементов)
//     Dictionary<int, int> freqDict = new Dictionary<int, int>();

//     // Перебор элементов массива и проверка наличия значения в словаре
//     foreach (int value in array)
//     {
//         if (freqDict.ContainsKey(value))
//             freqDict[value]++;
//         else
//             freqDict.Add(value, 1);
//     }

//     return freqDict;
// }
// // Выводит элементы массива в консоль
// void Output2DArray(int[,] array, string message)
// {
//     Console.WriteLine();
//     Console.WriteLine(message);

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("{");

//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//             Console.Write(array[i, j] + ",\t ");

//         Console.WriteLine(array[i, array.GetLength(1) - 1] + "}");
//     }
// }
// // Выводит словарь в консоль
// void OutputFrequencyDictionary(Dictionary<int, int> freqDict, string message)
// {
//     Console.WriteLine();
//     Console.WriteLine(message);

//     foreach(KeyValuePair<int,int> pair in freqDict)
//     {
//         Console.WriteLine($"{pair.Key} -> {pair.Value}");
//     }
// }

// // Получение данных от пользователя
// int m = Prompt("Введите количество столбцов в массиве: ");
// int n = Prompt("Введите количество строк в массиве: ");
// // Границы для случайного заполнения массива 
// // int minElement = 0;
// // int maxElement = 10;

// // int[,] array = new int[n, m];
// // IntRandom2DArray(array, minElement, maxElement); // Заполнение массива

// // Dictionary<int, int> freqDict = Frequency(array); // Заполнение словаря

// // Output2DArray(array, "Массив: "); // Вывод массива
// // OutputFrequencyDictionary(freqDict, "Частотный словарь: "); // Вывод словаря

// //------------------------------------------------------------------------------------------------------------------
// //                                                   Задача 57                                     
// //   Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// //   информацию о том, сколько раз встречается элемент входных данных.

// //------------------------------------------------------------------------------------------------------------------

// //                                                 Тело программы
// //------------------------------------------------------------------------------------------------------------------
// Console.Clear();
// // Ввод парметров матрицы.
// int countRow = ReadInt("Введите количество строк m: ");
// int countCol = ReadInt("Введите количество cтолбцов n: ");

// // Генерация и вывод матрицы.
// int minValue = 0;
// int maxValue = 10;
// int[,] matrix = CreateRandomMatrix(countRow, countCol, minValue, maxValue);
// PrintMatrix("Заданная матрица", matrix);

// // Создание и вывод частотного словаря
// Dictionary<int, int> frequencyDictionary = CreateFrequencyDictionary(matrix);
// PrintDictionary(frequencyDictionary);

// //------------------------------------------------------------------------------------------------------------------
// // Ввод целого числа с клавиатуры.
// int ReadInt(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Генераци двумерного массива, заполненного случайными целыми значениями.
// int[,] CreateRandomMatrix(int countRow, int countCol, int minValue, int maxValue)
// {
//     Random random = new Random();
//     int[,] matrix = new int[countRow, countCol];

//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countCol; j++)
//         {
//             matrix[i, j] = random.Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// // Вывод двумерного массива на экран.
// void PrintMatrix(string msg, int[,] matrix)
// {
//     Console.WriteLine("\n" + msg);

//     int rowCount = matrix.GetLength(0);
//     int colCount = matrix.GetLength(1);

//     for (int i = 0; i < rowCount; i++)
//     {
//         for (int j = 0; j < colCount; j++)
//         {
//             Console.Write($"{matrix[i, j],4} ");
//         }
//         Console.WriteLine();
//     }
// }

// // Заполнение частотного словаря
// Dictionary<int, int> CreateFrequencyDictionary(int[,] matrix)
// {
//     int rowCount = matrix.GetLength(0);
//     int colCount = matrix.GetLength(1);

//     Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();

//     for (int i = 0; i < rowCount; i++)
//     {
//         for (int j = 0; j < colCount; j++)
//         {
//             if (frequencyDictionary.ContainsKey(matrix[i, j]))
//             {
//                 frequencyDictionary[matrix[i, j]]++;
//             }
//             else
//             {
//                 frequencyDictionary[matrix[i, j]] = 1;
//             }
//         }
//     }

//     return frequencyDictionary;
// }

// // Вывод  частотного словаря на экран
// void PrintDictionary(Dictionary<int, int> frequencyDictionary)
// {
//     Console.WriteLine("\nЧастотный словарь:");
//     foreach (var kvp in frequencyDictionary)
//     {
//         Console.WriteLine($"{kvp.Key} встречается {kvp.Value} раз{(kvp.Value > 1 ? "а" : "")}");
//     }
// }