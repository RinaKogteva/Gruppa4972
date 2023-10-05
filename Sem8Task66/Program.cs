// ДЗ Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SetNumber(string message)
{
    Console.Write($"{message}");
    string strNum = Console.ReadLine()!;
    int num = 0;
    if (int.TryParse(strNum, out num))
        return num;
    Console.WriteLine("Неверный формат");
    return SetNumber(message);
}

int SumNumbers(int m, int n)
{
    if (m == n)
        return n;
    int sum = m + SumNumbers(m + 1, n);
    return sum;
}

int m = SetNumber("Введите число M: ");
int n = SetNumber("Введите число N: ");
int sum = SumNumbers(m, n);
Console.WriteLine(sum);
