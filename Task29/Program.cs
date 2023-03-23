// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();

Console.Write("Введите размер массива: ");

int arraySize = Convert.ToInt32(Console.ReadLine());

if (arraySize <= 0)
{
  Console.WriteLine($"Ошибка: введено неверное значение {arraySize}");
  return;
}

int[] arr = CreateArray(arraySize);

// PrintArray(arr);

PrintArr(arr);

int[] CreateArray(int arrayLength)
{
  int[] newArray = new int[arrayLength];

  Random random = new Random();

  for (int i = 0; i < arrayLength; i++)
  {
    newArray[i] = random.Next(0, 15);
  }

  return newArray;
}

// void PrintArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write($"{array[i]} ");
//   }
// }

void PrintArr(int[] arr)
{
  Console.WriteLine("[{0}]", string.Join(", ", arr));
}