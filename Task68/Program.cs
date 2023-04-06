// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int NumberM = ReadPositiveInteger("Введите целое положительное число M: ");
int NumberN = ReadPositiveInteger("Введите целое положительное число N: ");

int result = AckermannFunction(NumberM, NumberN);
Console.WriteLine($"Результат функции Аккермана для чисел {NumberM} и {NumberN}: {result}");

static int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
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