﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Сделать через словарь 

// Вывод сообщения и запись полученного числа
// bool Prompt(string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine()??",";
//     int number = Convert.ToInt32(value);

//     if (number < 10000 || number > 99999) 
//     {
//         Console.WriteLine("Число не пятизначное");
//         return false;
//     }

//     Dictionary<int, int> numberDictionary = NumberToDictionary(number);

//     return CheckingPalindrome(numberDictionary);
// }

// // Запись цифр числа в словарь в обратном порядке
// Dictionary<int,int> NumberToDictionary(int number)
// {
//     Dictionary<int, int> nums = new Dictionary<int, int>();
//     for (int i = 5; i >= 1; i--)
//     {
//         nums.Add(i, number % 10);
//         number = number / 10;
//     }

//     return nums;
// }

// //12321 - > 1221
// //23132 - > 2332

// // Проверяет, является ли число палиндромом
// bool CheckingPalindrome(Dictionary<int, int> numberDictionary)
// {
//     if (numberDictionary[5] == numberDictionary[1] && numberDictionary[4] == numberDictionary[2])
//         return true;
//     else return false;
// }


// Console.WriteLine(Prompt("Введите число: "));


using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
       if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        int originalNumber = number;
        int reverseNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reverseNumber = reverseNumber * 10 + digit;
            number = number / 10;
        }

        if (originalNumber == reverseNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 234322;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}