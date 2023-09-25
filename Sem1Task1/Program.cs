﻿// Console.WriteLine("Введите число 1:");
// int num1 = int.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine("Введите число 2:");
// int num2 = int.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine(num1 == Math.Pow(num2, 2) ? "Да" : "Нет");

// //<условие>?<вариант1>:<вариант2>
// if (num1 == Math.Pow(num2, 2))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// System.Console.WriteLine("Введите два числа");
// int numb1 = Convert.ToInt32(Console.ReadLine());
// int numb2 = Convert.ToInt32(Console.ReadLine());
// int x = numb2 * numb2;
// if (numb1 == x) 
// {
//     System.Console.WriteLine("Первое число является квадратом второго");
// }
// else 
// {
//  System.Console.WriteLine("первое число не является квадратом второго");
// }

Console.WriteLine("Enter first num");
int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Enter first num");
int secondNum = int.Parse(Console.ReadLine());

if(firstNum == Math.Pow(secondNum, 2))
{
	Console.WriteLine("First number is a square of second number");
}