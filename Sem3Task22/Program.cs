﻿// int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine()??"0");
//     return num;
// }

// string BuildLine(int n, int pow)
// {
//     //string res = string.Empty;
//     string res = "";
//     for(int i = 1; i <= n; i++)
//     {
//         res = res + Math.Pow(i,pow)+ " ";
//     }
//     return res;
// }

// void PrintResult(string msg) // печатаем результат
// {
//     Console.WriteLine(msg);
// }

// int n = ReadData("Введите число");
// PrintResult(BuildLine(n, 1));
// PrintResult(BuildLine(n, 2));

// Вывод сообщения и вызов метода OutputSquares
void Prompt(string message)
{
    Console.WriteLine(message);
    string values = Console.ReadLine()??",";
    int number = Convert.ToInt32(values);

    OutputSquares(number);
}

// Расчёт квадратов и составление таблицы
void OutputSquares(int number)
{
    Console.Clear();

    int currentNumber = 0;
    int currentNumberSquare;
    int cursor = 0;

    while (currentNumber <= number)
    {
        currentNumberSquare = (int)Math.Pow(currentNumber, 2);

        Console.SetCursorPosition(cursor, 0);
        Console.Write(currentNumber);

        Console.SetCursorPosition(cursor, 1);
        Console.Write(currentNumberSquare);

        cursor = Console.CursorLeft + 3;

        currentNumber++;
    }
}

Prompt("Введите число: ");