// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] randomArray = CreateArrayRndInt(10, -10, 10);

int result = SumOddNumbers(randomArray);

PrintArray(randomArray);
Console.WriteLine($"Сумма чисел = {result}");

int SumOddNumbers(int[] arr)
{
  int sum = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (i % 2 != 0) sum = arr[i] + sum;
  }
  return sum;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
  int[] array = new int[size];
  Random random = new Random();

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(min, max + 1);
  }

  return array;
}

void PrintArray(int[] arr)
{
  Console.WriteLine("[{0}]", string.Join(", ", arr));
}