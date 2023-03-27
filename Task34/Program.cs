// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

int[] randomArray = CreateArrayRndInt(10, 100, 999);

int result = EvenNumbers(randomArray);

Console.WriteLine($"Четных числех в массиве = {result} ");
PrintArray(randomArray);


int EvenNumbers(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;

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