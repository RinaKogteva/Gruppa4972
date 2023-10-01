//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 27
//                                      Домашнее задание к семинару 04
//   Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//   * Сделать оценку времени алгоритма через вещественные числа и строки
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
//Console.Clear(); // Очистка консоли
// int number = ReadData("Введите целое число: "); // Ввод числа с клавиатуры

// CalculateAndPrintSum("Метод деления", number, SumDigitDiv); // Сумма методом деления
// //CalculateAndPrintSum("Метод строки", number, SumDigitStr);  // Сумма методом строки


// //                                                     Методы
// //------------------------------------------------------------------------------------------------------------------
// // Ввод данных с клавиатуры
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// // Вывод результата
// void CalculateAndPrintSum(string methodName, int number, Func<int, int> calculator)
// {
//     DateTime startTime = DateTime.Now;
//     int sum = calculator(number);
//     TimeSpan executionTime = DateTime.Now - startTime;
//     Console.WriteLine($"\n{methodName}:\nСумма цифр числа {number} = {sum}\nВремя исполнения {executionTime}");
// }

// // Вычисление суммы цифр через вещественные числа
// int SumDigitDiv(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number /= 10;
//     }
//     return result;
// }

// //Вычисление суммы цифр через строку
// int SumDigitStr(int number)
// {
//     string numberStr = number.ToString();
//     int result = 0;

//     foreach (char digitChar in numberStr) { result += int.Parse(digitChar.ToString()); }
//     return result;


// }


//Домашнее задание к семинару 4. Задача №27 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12




int number = ReadInt("Введите число: ");

int len = NumberLen(number);
SumNumbers(number, len);

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"сумма цифр {sum}");
}

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

