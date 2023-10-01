// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
// Осуществить возможность ввода всех точек в одну строку

// Вывод сообщения и вызов метода DistanceCalculation
double Prompt(string message1)
{
    Console.WriteLine(message1);
    string values = Console.ReadLine()??",";

    string[] valuesArray = values.Split(",");
    int xA = Convert.ToInt32(valuesArray[0]);
    int yA = Convert.ToInt32(valuesArray[1]);
    int zA = Convert.ToInt32(valuesArray[2]);
    int xB = Convert.ToInt32(valuesArray[3]);
    int yB = Convert.ToInt32(valuesArray[4]);
    int zB = Convert.ToInt32(valuesArray[5]);

    return DistanceCalculation(xA, yA, zA, xB, yB, zB);
}


//A (3,6,8); B (2,1,-7)
// Расчёт расстояния
double DistanceCalculation(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow(Math.Abs(xA - xB), 2)
                    + Math.Pow(Math.Abs(yA - yB), 2)
                    + Math.Pow(Math.Abs(zA - zB), 2));
}

Console.WriteLine(Prompt("Введите 6 чисел через запятую (xA,yA,zA,xB,yB,zB): "));
