// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
if (number >= 100 )
{
  int total = ThirdDigit(number);
  Console.WriteLine($"Третья цифра этого числа = {total}");
}
else
  Console.WriteLine("В этом числе нет третьей цифры");

int ThirdDigit(int num)
{
  while (num > 999)
  {
    num = num / 10;
  }
  int result = num % 10;
  return result;
}