// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();

int NumberM = ReadPositiveInteger("Введите целое положительное число M: ");
int NumberN = ReadPositiveInteger("Введите целое положительное число N: ");

int result = AckermannFunction(NumberM, NumberN, 0);
Console.WriteLine($"\nРезультат функции Аккермана для чисел {NumberM} и {NumberN}: {result}");

int AckermannFunction(int m, int n, int result = 0)
{
  if (m == 0)
  {
    return n + 1 + result;
  }
  else if (n == 0)
  {
    return AckermannFunction(m - 1, 1, result);
  }
  else
  {
    // вызываем функцию с измененными параметрами
    // при этом результат предыдущего вызова передаем в параметр result
    return AckermannFunction(m, n - 1, AckermannFunction(m - 1, 1, result));
  }
}

// метод для чтения положительного целого числа
int ReadPositiveInteger(string message)
{
  while (true)
  {
    Console.Write(message);
    // проверяем, что введенное значение является целым положительным числом
    if (int.TryParse(Console.ReadLine(), out int result) && result > 0)
    {
      // Число 25 было вычесленно методом подбора. После него программа уже долго вычисляет результат.
      // Если в коде не нужны "магические цифры", то можно убрать из кода 5 строчек ниже.
      if (result > 25)
      {
        Console.WriteLine("Не стоит вводить число больше 25, т.к. программа будет долго считать.\n");
        continue; // перезапускаем цикл, чтобы получить новое число
      }
      return result;
    }
    Console.WriteLine("Ошибка! Введите положительное целое число.\n");
  }
}
