// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();

int NumberM = ReadPositiveInteger("Введите целое положительное число M: ");
int NumberN = ReadPositiveInteger("Введите целое положительное число N: ");

int sum = SumNaturalNumbers(NumberM, NumberN);
Console.WriteLine($"Сумма натуральных чисел в промежутке от {NumberM} до {NumberN}: {sum}");

int SumNaturalNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else if (m < n)
    {
        return n + SumNaturalNumbers(m, n - 1);
    }
    else
    {
        return m + SumNaturalNumbers(m - 1, n);
    }
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