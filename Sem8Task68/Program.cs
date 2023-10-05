// ДЗ Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int SetNumber(string message)
{
    Console.Write($"{message}");
    string strNum = Console.ReadLine()!;
    int num = 0;
    if (int.TryParse(strNum, out num))
        	if (num >= 0)
                return num;
    Console.WriteLine("Введите неотрицательое число!");
    return SetNumber(message);
}

int Ankerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
        return Ankerman(m - 1, 1);
    if (m > 0 && n > 0)
        return Ankerman(m - 1, Ankerman(m, n - 1));
    return Ankerman(m,n);
}

int m = SetNumber("Введите число m: ");
int n = SetNumber("Введите число n: ");
Console.WriteLine($"A({m}, {n}) = {Ankerman(m, n)}");
