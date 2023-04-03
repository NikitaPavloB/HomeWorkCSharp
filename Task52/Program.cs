// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);

PrintMatrix(matrix);
Console.WriteLine();

double[] averageValues = GetAverageColumnValues(matrix);

for (int i = 0; i < averageValues.Length; i++)
{
    Console.WriteLine($"Среднеарифметическое столбца {i + 1}: {averageValues[i]}");
}

 double[] GetAverageColumnValues(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);

  double[] averageValues = new double[columns];

  for (int j = 0; j < columns; j++)
  {
    double columnSum = 0;
    for (int i = 0; i < rows; i++)
    {
      columnSum += matrix[i, j];
    }
    averageValues[j] = Math.Round(columnSum / rows, 1);
  }

  return averageValues;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j], 5} ");
    }
    Console.WriteLine("|");
  }
}