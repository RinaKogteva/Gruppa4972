﻿// See https://aka.ms/new-console-template for more information


// int f = int.Parse(Console.ReadLine()??"0");
// int s = int.Parse(Console.ReadLine()??"0");

// Console.WriteLine((s%f==0)?true:s%f);


Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num2%num1==0?"Второе число кратно первому":"Остаток от деления: " + (num2%num1));