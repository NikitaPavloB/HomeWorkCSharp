// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;

int result = SumDigits(number);
Console.WriteLine($"Сумма всех цифр в числе {number} = {result}");

int SumDigits(int num)
{
  int sum = 0;
  while (num > 0)
  {
    sum += num % 10;
    num = num / 10;
  }
  return sum;
}

