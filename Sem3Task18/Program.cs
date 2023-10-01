﻿//Анастасия Г.
// // Вывод сообщения и вызов метода CheckingCoordinates
// string Prompt(string message)
// {
//     Console.WriteLine(message);
//     string values = Console.ReadLine()??",";
//     int quarter = Convert.ToInt32(values);

//     return CheckingCoordinates(quarter);
// }

// // Проверка четверти
// string CheckingCoordinates(int quarter)
// {
//     switch(quarter)
//     {
//         case 1: return "(X > 0 ; Y > 0)";
//         case 2: return "(X < 0 ; Y > 0)";
//         case 3: return "(X < 0 ; Y < 0)";
//         case 4: return "(X > 0 ; Y < 0)";
//         default: return "0";
//     }
// }

// Console.WriteLine(Prompt("Введите номер четверти: "));

//Максим М.
int getQuarter()
{
    Console.Write("Введите номер четверти: ");
    return Convert.ToInt32(Console.ReadLine());
}

// //Вводим данные
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

string pointsIdent(int quarterNum)
{
    if (quarterNum == 1) return "Возможные значения: X > 0, Y > 0";
    if (quarterNum == 2) return "Возможные значения: X < 0, Y > 0";
    if (quarterNum == 3) return "Возможные значения: X < 0, Y < 0";
    if (quarterNum == 4) return "Возможные значения: X > 0, Y < 0";
    return "Неверное значение";
}

int quarterNum = getQuarter();
Console.WriteLine(pointsIdent(quarterNum));