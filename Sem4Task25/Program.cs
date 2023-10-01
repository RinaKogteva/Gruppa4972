﻿// // №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // * Написать калькулятор с операциями +, -, /, * и возведение в степень

// //Вводим данные
// string ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     string data = Console.ReadLine();
//     return data;
// }

// //Функция сложения
// double plus(int a, int b)
// {
//     double result = a + b;
//     return result;
// }

// //Функция вычитания
// double minus(int a, int b)
// {
//     double result = a - b;
//     return result;
// }

// //Функция умножения
// double multiplication(int a, int b)
// {
//     double result = a * b;
//     return result;
// }

// //Функция деления
// double division(int a, int b)
// {
//     double result = a / b;
//     return result;
// }

// //Функция возведения в степень
// double degree(int a, int b)
// {
//     double result = Math.Pow(a, b);
//     return result;
// }

// //Печатаем результат
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }



// int a = int.Parse(ReadData("Введите число А"));
// int b = int.Parse(ReadData("Введите число B"));
// string operand = ReadData("Введите операцию (+, -, *, /, ^)");

// //double result = getResult(a, b, operand);

// double result = 0;

// switch (operand)
// {
//     case "+": 
//     result = plus(a, b);
//     break;
//     case "-": 
//     result = minus(a, b);
//     break;
//     case "*": 
//     result = multiplication(a, b);
//     break;
//     case "/": 
//     result = division(a, b);
//     break;
//     case "^": 
//     result = degree(a, b);
//     break;
//     default: Console.WriteLine("Что-то пошло не так");
//     break;
// }

// PrintResult("Результат операции = " + result);

//Домашнее задание к семинару 4. Задача № 25.


// int numberA = ReadInt("Введите число: ");
// int numberB = ReadInt("Введите степень: ");
// ToDegree(numberA, numberB);


// // Функция возведения в степень
// void ToDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(a + " в степени " + b + " = " + result);
// }

// // Функция ввода
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

//.............................................................................................................

string InputExpression(string msg) //ввод точки в виде строки
{
    Console.WriteLine(msg);
    return Console.ReadLine()??"0";
}

double[] Pair(string sExpression) //парсим строку на числа
{
    double[] pair = new double[2];
    char[] cExpression = sExpression.ToCharArray();
    int j = 0;
    for (int i = 0; i < pair.Length; i++)
    {
        string value = string.Empty;
        //пропускаем все кроме кроме цифр, точки и минуса
        while ((cExpression[j] < '0' || cExpression[j] > '9') && 
        cExpression[j] != '.' && cExpression[j] != '-') 
        {
            j++;
            if(j >= cExpression.Length) break;
        }
        //из цифр точки и минусов собираем числа
        while (cExpression[j] >= '0' && cExpression[j] <= '9' || cExpression[j] == '.' ||
         cExpression[j] == '-')
        {
            value = value + cExpression[j].ToString();
            j++;
            if(j >= cExpression.Length || cExpression[j] == '-') break; //если следующий знак - или стока кончается, то прерываем цикл
        }
        pair[i] = double.Parse(value ??"0");
    }
    return pair;
}
//выясняем какое действие надо совершить
char Action(double[] pair, string sExpression)
{
    int begin = pair[0].ToString().Length;
    char[] cExpression = sExpression.Trim().ToCharArray();
    int end = cExpression.Length - pair[1].ToString().Length;
    for(int i = begin; i < end; i++)
    {
        if(cExpression[i] == '+' || cExpression[i] == '-' || cExpression[i] == '*' || 
        cExpression[i] == '/' || cExpression[i] == '^') return cExpression[i];
    }
    return '+';

}
// Целочисленное возведение в степень
double ZPower(double basis, int pow)
{
    double res = 1;
    for(int i = 0; i < Math.Abs(pow); i++)
    {
        res*=basis;
    }
    if(pow < 0) return 1 / res;
    return res;
}

//Вычисляем выражение
double Result(double[] pair, char act)
{
    switch (act)
    {
        case '+': return pair[0] + pair[1];
        case '-': return pair[0] - pair[1];
        case '*': return pair[0] - pair[1];
        case '/': return pair[0] / pair[1];
        case '^': 
        {
            if(pair[1] != (int)pair[1]) // если степень не целая, применяем встроенную функцию
            {
                return Math.Pow(pair[0], pair[1]);
            } else { // в противном случае применяем целочисленное 
            //возведение в степень, чтобы можно было возводить и отрицательные числа
                return ZPower(pair[0], (int)pair[1]);
            }
        }
        default: return pair[0] * pair[1];
    }
}

Console.Clear();
string expression = InputExpression("Введите выражение в виде А<действие>B: ");

double[] pair = Pair(expression);

char act = Action(pair, expression); 

Console.WriteLine($"Результат выражения {pair[0]} { act.ToString() } {pair[1]} = {Result(pair, act)}");