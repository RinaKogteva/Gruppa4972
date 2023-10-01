// Домашнее задание  к семинару 1. Задача № 6
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

﻿Console.Write("Введите число чтобы узнать является ли оно чётным: ");
int num = int.Parse(Console.ReadLine());
int remain = num % 2;
if (remain == 0)
{
    Console.Write(num + " - ");
    Console.WriteLine("чётное");
}
else
{
    Console.Write(num + " - ");
    Console.WriteLine("не чётное");
}