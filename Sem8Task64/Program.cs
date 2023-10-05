// ДЗ Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int SetNumber(string message)
{
    Console.Write($"{message}");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

string PrintNumbers(int start, int stop)
{
    if (start == stop) 
        return Convert.ToString(start);
    return $"{start}, {PrintNumbers(start - 1, stop)}";
}

int start = SetNumber("Введите число N: ");
int stop = 1;
Console.WriteLine(PrintNumbers(start, stop));
