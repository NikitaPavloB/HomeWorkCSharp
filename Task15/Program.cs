// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите число указывающее день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 8)
{
  Console.WriteLine("У нас в неделе семь дней. Введите корректное число!");
}
else
{
  bool result = DayOff(number);
  Console.WriteLine(result ? "О да, наступил выходной!"
                            : "Работаем, негры, ещё не выходной!");
}

bool DayOff(int num)
{
  return num > 5 && num <= 7;
}