﻿// Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал

// Вывод сообщения и запись введённых данных
// string[] Prompt(string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine()??",";
//     string[] names = value.Replace(".", ",").Replace(" ", "").Split(",");

//     return names;
// }
// // Выбирает случайный индекс массива
// int RandomName(int length)
// {
//     return new Random().Next(0, length);
// }

// string[] names = Prompt("Введите имена через запятую или точку: ");

// Console.WriteLine(names[RandomName(names.Length)]);

//Домашнее задание к семинару 4. Задача №29 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}