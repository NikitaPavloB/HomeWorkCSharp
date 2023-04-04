// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] matrixA = CreateMatrix(4, 4, 0, 10);
int[,] matrixB = CreateMatrix(4, 4, 0, 10);

Console.WriteLine("Первая матрица:");
PrintMatrix(matrixA);
Console.WriteLine();

Console.WriteLine("Вторая матрица:");
PrintMatrix(matrixB);
Console.WriteLine();

if (!CheckSize(matrixA, matrixB))
{
  Console.WriteLine("Умножение невозможно!");
  return;
}

int[,] productMatrix = ProductMatrices(matrixA, matrixB);

Console.WriteLine("Произведение матриц:");
PrintMatrix(productMatrix);

static bool CheckSize(int[,] matrixA, int[,] matrixB)
{
  if (matrixA.GetLength(1) != matrixB.GetLength(0))
  {
    Console.WriteLine("Число столбцов первой матрицы должно быть равно числу строк второй матрицы\n");
    return false;
  }

  return true;
}

static int[,] ProductMatrices(int[,] matrixA, int[,] matrixB)
{
  int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrixA.GetLength(1); k++)
      {
        sum += matrixA[i, k] * matrixB[k, j];
      }
      resultMatrix[i, j] = sum;
    }
  }

  return resultMatrix;
}

static int[,] CreateMatrix(int rows, int columns, int min, int max)
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

static void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],5} ");
    }
    Console.WriteLine("|");
  }
}
