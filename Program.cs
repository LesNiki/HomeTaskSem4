﻿// // //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // //1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // //6, 1, 33 -> [6, 1, 33]

// int [] GetArray()
// {
//     int[] array = new int[8]; // задали пустой массив из нулей длины 8
    
//     for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = new Random().Next(-10000, 10000);
//         }
//     return array;
// }    
// Console.WriteLine(String.Join (",", GetArray()));

-----------------------------------------------------------------------------------------------------------

// //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// //3, 5 -> 243 (3⁵)
// //2, 4 -> 16

// Console.WriteLine("Введите число A");
// int numA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число B");
// int numB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Pow(numA,numB));

----------------------------------------------------------------------------------------------------

// //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// //452 -> 11
// //82 -> 10
// //9012 -> 12

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = 0;

// while (num != 0)
// {
//     result = result + num % 10;
//     num = num / 10;
// }

// Console.WriteLine(result);