﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите 3-значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.WriteLine(number / 10 % 10);
}
else if (number > -1000 && number < -99)
{
    Console.WriteLine(-number / 10 % 10);
}
else Console.WriteLine("Это не 3-значное число");
