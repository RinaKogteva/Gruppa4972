﻿// //№43* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// //1 0,-1 2,0 0 — Должно получиться ~1
// //(Задание со звездочкой) Найдите площадь треугольника образованного пересечением 3 прямых 

// Line ReadParameters(string msg) //На вход принимаем коэффициенты k и b — они образуют объект класса Line(описан внизу)
// {
//     Console.WriteLine(msg);
//     string initialString = Console.ReadLine() ?? "0";
//     initialString = (initialString.TrimEnd()).TrimStart(); //Удаляем пробелы в начале и конце строки,если они есть.
//     string[] points = initialString.Split(' '); //Разбиваем входящую строку по пробелу на несколько строк.
//     points = Array.FindAll(points, isNotEmpty).ToArray(); //Если случайно ввели лишний пробел — исправляем.
//     Line line = new Line();
//     line.k = Convert.ToDouble(points[0]);
//     line.b = Convert.ToDouble(points[1]);
//     return line;
// }

// bool isNotEmpty(string n) //Вспомогательный метод для нахождения непустых элементов массива строк
// {
//     return !n.Equals(String.Empty);
// }

// Line lineA = ReadParameters("Введите коэффициенты первой прямой через пробел"); //читаем коэффициенты
// Line lineB = ReadParameters("Введите коэффициенты второй прямой через пробел");
// Line lineC = ReadParameters("Введите коэффициенты третьей прямой через пробел");
// Triangle triangle = new Triangle(); //"Создаём" треугольник и ниже проверяем,не являются ли какие-либо из 
//                                     //прямых параллельными
// if (triangle.IsNotPossible(lineA, lineB, lineC)) { Console.WriteLine("Такой треугольник невозможен"); Environment.Exit(0); }
// Point intersectAB = triangle.CrossPoint(lineA, lineB); //point B на плоскости
// Point intersectAC = triangle.CrossPoint(lineA, lineC); //point A на плоскости
// Point intersectBC = triangle.CrossPoint(lineB, lineC); //point C на плоскости
// double sideAB = triangle.SideLength(intersectAB, intersectAC); //Вычисляем длины сторон
// double sideAC = triangle.SideLength(intersectAC, intersectBC);
// double sideBC = triangle.SideLength(intersectAB, intersectBC);
// double sq = triangle.Square(sideAB, sideBC, sideAC); //Считаем площадь через 3 стороны и полупериметр
// Console.WriteLine("Площадь треугольника равна " + sq);

// public class Triangle //Все вычисления проводятся в этом классе
// {
//     //Проверка,что нет параллельных прямых 
//     public bool IsNotPossible(Line lineone, Line linetwo, Line linethree)
//     {
//         return (lineone.k == linetwo.k) || (lineone.k == linethree.k) || (linetwo.k == linethree.k);
//     }
//     //Считаем точки пересечения
//     public Point CrossPoint(Line lineone, Line linetwo)
//     {
//         Point crspoint = new Point();
//         crspoint.x = (linetwo.b - lineone.b) / (lineone.k - linetwo.k); // 
//         crspoint.y = lineone.k * crspoint.x + lineone.b;
//         return crspoint;
//     }

//     //Считаем стороны треугольника
//     public double SideLength(Point crspointA, Point crspointB)
//     {
//         return Math.Sqrt(Math.Pow((crspointB.x - crspointA.x), 2) + Math.Pow((crspointB.y - crspointA.y), 2));
//     }
//     //Считаем площадь через полупериметр
//     public double Square(double sideA, double sideB, double sideC)
//     {
//         double perimeter = 0;
//         double square = 0;
//         perimeter = (sideA + sideB + sideC) / 2;
//         square = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
//         return square;
//     }
// }
// public class Line //Прямые линии (kx+b)
// {
//     public double k, b = 0; //Коэффициенты прямой
// }

// public class Point 
// {
//     public double x, y = 0; //Точка на плоскости
// }

// * Найдите площадь треугольника образованного пересечением 3 прямых 
//   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

// double K1 = ReadData("Input number K1: ");
// double B1 = ReadData("Input number B1: ");
// double K2 = ReadData("Input number K2: ");
// double B2 = ReadData("Input number B2: ");
// double K3 = ReadData("Input number K3: ");
// double B3 = ReadData("Input number B3: ");
// // Поиск координат пересечения
// (double x, double y) pointA = CrossPoint(K1, B1, K2, B2);
// (double x, double y) pointB = CrossPoint(K2, B2, K3, B3);
// (double x, double y) pointC = CrossPoint(K3, B3, K1, B1);

// double X1 = pointA.x;
// double Y1 = pointA.y;
// double X2 = pointB.x;
// double Y2 = pointB.x;
// double X3 = pointC.x;
// double Y3 = pointC.x;
// PrintData($"Cross points of 3 lines: X1= {X1}; Y1= {Y1}, X2= {X2}; Y2= {Y2}, X3= {X3}; Y3= {Y3}");
// double sideA = TriangleSide(X1, Y1, X2, Y2);
// double sideB = TriangleSide(X2, Y2, X3, Y3);
// double sideC = TriangleSide(X3, Y3, X1, Y1);
// PrintData($"The length of triangle sides: A= {sideA}; B= {sideB}, C= {sideC}");
// PrintData($"The square of triangle: S= {SquareTriangle(sideA, sideB, sideC)}");

// // Метод считывания введенных данных.
// double ReadData(string msg)
// {
//     Console.Write(msg);
//     return double.Parse(Console.ReadLine() ?? "0");
// }
// // Метод вывода данных.
// void PrintData(string msg)
// {
//     Console.WriteLine(msg);
// }
// // комплексный метод
// (double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
// {
//     double coorX1 = (b2 - b1) / (k1 - k2);
//     double coorY1 = (k1 * b2 - k2 * b1) / (k1 - k2);
//     return (coorX1, coorY1);
// }
// //Находим стороны треугольника, разбила на 3 отдельных метода, чтобы получить сразу переменные в double.
// double TriangleSide(double x1, double y1, double x2, double y2)
// {
//     double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
//     return result;
// }
// // Находим площадь треугольника через полумериметр (p=(a + b + c) / 2 )сторон и длины сторон.
// double SquareTriangle(double a, double b, double c)
// {
//     double squareT = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
//     return squareT;
// }

Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"\n Точка пересечения двух прямых: [{x},{y}]");