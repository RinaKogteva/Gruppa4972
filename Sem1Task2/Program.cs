//Домашнее задание к семинару 1. Задача №2
//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите число 1:");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число 2:");
int b = int.Parse(Console.ReadLine() ?? "0");


if (a > b)
{
    Console.Write("max=");
    Console.Write(a);
}
else if (a == b)
{
    Console.Write(" равен ");
}
else
{
    Console.Write("max=");
    Console.WriteLine(b);
};
