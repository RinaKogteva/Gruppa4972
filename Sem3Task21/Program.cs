// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
// Осуществить возможность ввода всех точек в одну строку

// Вывод сообщения и вызов метода DistanceCalculation
// 


// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB 
// в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.


using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
      
       var xPow = Math.Pow(pointB[0] - pointA[0],2);
       var yPow = Math.Pow(pointB[1] - pointA[1],2);
       var zPow = Math.Pow(pointB[2] - pointA[2],2);
       return Math.Sqrt(xPow + yPow + zPow);

    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}