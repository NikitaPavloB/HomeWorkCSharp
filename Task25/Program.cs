// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0) number1 = -number1;
if (number2 < 0) number2 = -number2;

int total = Exponentiation(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} = {total}");

int Exponentiation(int num1, int num2)
{
  int result = 1;
  for (int i = 0; i < num2; i++)
  {
    result *= num1;
  }
  return result;
}
