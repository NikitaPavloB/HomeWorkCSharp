// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();

int NumberM = ReadPositiveInteger("Введите целое неотрецательное число M: ");
int NumberN = ReadPositiveInteger("Введите целое неотрецательное число N: ");

int result = AckermannFunction(NumberM, NumberN);
Console.WriteLine($"\nРезультат функции Аккермана для чисел {NumberM} и {NumberN}: {result}");

int AckermannFunction(int m, int n)
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
// метод для чтения неотрецательным целого числа
int ReadPositiveInteger(string message)
{
  while (true)
  {
    Console.Write(message);
    // проверяем, что введенное значение является целым неотрецательным числом
    if (int.TryParse(Console.ReadLine(), out int result) && result >= 0)
    {
      return result;
    }
    Console.WriteLine("Ошибка! Введите целое неотрецательное число.\n");
  }
}
