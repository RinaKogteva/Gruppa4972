﻿// int day = int.Parse(Console.ReadLine()??"0");

// string[] dayOfWeek = new string[7];

// dayOfWeek[0]="Понедельник";
// dayOfWeek[1]="Вторник";
// dayOfWeek[2]="Среда";
// dayOfWeek[3]="Четверг";
// dayOfWeek[4]="Пятница";
// dayOfWeek[5]="Суббота";
// dayOfWeek[6]="Воскресенье";

// Console.WriteLine(dayOfWeek[day-1]);

// System.Console.WriteLine("Введите номер");
// int a = Convert.ToInt32 (Console.ReadLine());
// switch (a)
// {
//    case 1: Console.WriteLine ("Пн");
//    break;

//    case 2: Console.WriteLine ("Вт");
//    break;

//    case 3: Console.WriteLine ("Ср");
//    break;

//    case 4: Console.WriteLine ("Чт");
//    break;

//    case 5: Console.WriteLine ("Пт");
//    break;

//    case 6: Console.WriteLine ("Сб");
//    break;

//    case 7: Console.WriteLine ("Вс");
//    break;
// }

// string day = Console.ReadLine()??"0";

// switch (day)
// {
//     case "1": Console.WriteLine("Понедельник"); break;
//     case "2": Console.WriteLine("Вторник"); break;
//     case "3": Console.WriteLine("Среда"); break;
//     case "4": Console.WriteLine("Четверг"); break;
//     case "5": Console.WriteLine("Пятница"); break;
//     case "6": Console.WriteLine("Суббота"); break;
//     case "7": Console.WriteLine("Воскресенье"); break;
//     default: Console.WriteLine("Неверные данные"); break;
// }

// Console.WriteLine("Enter day number");
// int dayNum = int.Parse(Console.ReadLine());

// if(dayNum == 1){
// 	Console.WriteLine("Monday");
// }
// else if(dayNum == 2){
// 	Console.WriteLine("Tuesday");
// }
// else if(dayNum == 3){
// 	Console.WriteLine("Wednesday");
// }
// else if(dayNum == 4){
// 	Console.WriteLine("Thursday");
// }
// else if(dayNum == 5){
// 	Console.WriteLine("Friday");
// }
// else if(dayNum == 6){
// 	Console.WriteLine("Saturday");
// }
// else if(dayNum == 7){
// 	Console.WriteLine("Sunday");
// }
// else {
// 	Console.WriteLine("Not day of week");
// }

Console.WriteLine("Enter day number");
int dayNum = int.Parse(Console.ReadLine());

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum));

Console.WriteLine(outDayOfWeek);