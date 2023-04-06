// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();

int number = ReadPositiveInteger("Введите целое положительное число: ");

NuturalNumbers(number);

void NuturalNumbers(int num)
{
  if (num == 0) return;
  Console.Write($"{num} ");
  NuturalNumbers(num - 1);
}

int ReadPositiveInteger(string message)
{
  while (true)
  {
    Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int result) && result > 0)
    {
      return result;
    }
    Console.WriteLine("Ошибка! Введите положительное целое число.");
  }
}
