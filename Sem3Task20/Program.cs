﻿// // Александр Л.

// double findDistance(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2));
// }

// int x1 = int.Parse(Console.ReadLine() ?? "0");
// int y1 = int.Parse(Console.ReadLine() ?? "0");
// int x2 = int.Parse(Console.ReadLine() ?? "0");
// int y2 = int.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine(findDistance(x1, y1, x2, y2));

// //Никита Е.
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// double Distance(int x,int y)
// {
//     double distance = Math.Sqrt(x*x+y*y);
//     return distance;
// }

// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// int x1 = ReadData("Введите координату x1: ");
// int y1 = ReadData("Введите координату y1: ");
// int x2 = ReadData("Введите координату x2: ");
// int y2 = ReadData("Введите координату y2: ");
// double res = Distance((x2-x1),(y2-y1));
// PrintResult("Расстояние равно " + $"{res}");

// Задание № 20
// Напишите программу ,которая принемает на вход координаты двух точек и находит расстояние между ними в двухмерном пространстве.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num= int.Parse(Console.ReadLine()??"0");
    return num;
}
double Calc2DDist(int x1,int x2,int y1,int y2)
{
    double res = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return res;
}
    // Печатаем результат
void PrintResult(string msg)
{
   Console.WriteLine (msg);
}
int x1=ReadData("Введите координату Х1: ");
int x2=ReadData("Введите координату Х2: ");
int y1=ReadData("Введите координату Y1: ");
int y2=ReadData("Введите координату Y2: ");
int buf = (x1-x2)*(x1-x2)+(y1-y2)*(y1-y2);
Console.WriteLine(buf);
double res=Calc2DDist(x1,x2,y1,y2);
PrintResult("Расстояние между точками равняется:"+ $"{res}");