// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
while (number > 999)
{
    number = number / 10;
}
if (number > 99)
{
    Console.WriteLine(number % 10);
}
else Console.WriteLine("Нет третьей цифры");
