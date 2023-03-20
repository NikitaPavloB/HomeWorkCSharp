// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.WriteLine("Введтие пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
if (number < 10000 || number >= 100000)
{
  Console.WriteLine("Введите пятизначное число!");
  return;
}

bool result = Palindrom(number);
Console.WriteLine(result ? "Да" : "Нет");

bool Palindrom(int num)
{
  int firstdigit = num % 10;
  int lastdigit = num / 10000;

  int second = num % 10;
  int seconddigit = second % 10;

  int fourth = num / 100;
  int fourthdigit = fourth / 10;

  return firstdigit == lastdigit || seconddigit == fourthdigit;
}
