﻿// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num % 7 == 0 && num % 23 == 0 ? "Кратно" : "Не кратно");