// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

double[] array = CreateArrayRandDoub(5, -5, 25, 1);

PrintArray(array);

DiffMaxMin(array);

double[] CreateArrayRandDoub(int size, int min, int max, int round)
{
  double[] arr = new double[size];
  Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    double num = rnd.NextDouble() * (max - min) + min;
    arr[i] = Math.Round(num, round);
  }
  return arr;
}

void PrintArray(double[] arr)
{
  Console.WriteLine("[{0}]", string.Join(", ", arr));
}

void DiffMaxMin(double[] arr)
{
  double min = arr[0];
  double max = arr[0];
  double diff = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
  }
  diff = max - min;
  Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diff}");
}
