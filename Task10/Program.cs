// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
  int total = SecondDigit(number);
  Console.WriteLine($"Вторая цифра = {total}");
}
else
{
  Console.WriteLine("Введите пожалуйста трехзначное число!");
}

int SecondDigit(int num)
{
  int secondDigit = num / 10 % 10;
  int result = secondDigit;
  return result;
}