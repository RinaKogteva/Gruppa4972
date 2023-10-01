﻿// int ran = new System.Random().Next(100, 1000);
// System.Console.WriteLine(ran);
// char[] digitChar = ran.ToString().ToCharArray();
// System.Console.Write(digitChar[0]);
// System.Console.Write(digitChar[2]);

//start:

Console.WriteLine("Чтобы выйти введите -1");
Console.Write("Введите число: ");
string stringNum = Console.ReadLine()??"0";
int num = Convert.ToInt32(stringNum);

if (num == -1) return;
if (stringNum.Length != 3)
    Console.WriteLine("Число не трёхзначное");
else
{
    Console.WriteLine((num / 100) * 10 + (num % 10));
}

// Console.WriteLine(stringNum.Length != 3 ? "Число не трёхзначное" : (num / 100) * 10 + (num % 10));

Console.WriteLine();

//goto start;