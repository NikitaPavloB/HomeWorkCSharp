﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
  Console.WriteLine($"Самое большое число = {number1} ");
  Console.WriteLine($"Самое маленькое число = {number2} ");
}
else
{
  Console.WriteLine($"Самое большое число = {number2} ");
  Console.WriteLine($"Самое маленькое число = {number1} ");
}