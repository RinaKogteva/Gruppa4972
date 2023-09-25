﻿// Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine()??"0");

// Console.WriteLine(num < 1000 && num > 99 ? num % 10 : "Число не трёхзначное");

Console.WriteLine("Введите трёхзначное число: ");
int num=int.Parse(Console.ReadLine()??"0");

if(num>99&&num<1000)
{
    int lastNum=num%10;
    Console.WriteLine("Последнее число "+num+" это "+lastNum);
}
else
{
    Console.WriteLine("Число не трехзначное");
}