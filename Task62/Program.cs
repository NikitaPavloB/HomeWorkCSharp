// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();

int[,] matrix = new int[4, 4];

FillSpiralMatrix(matrix);
PrintMatrix(matrix);

void FillSpiralMatrix(int[,] matrix)
{
  int count = 1;
  int rowStart = 0, rowEnd = matrix.GetLength(0) - 1;
  int colStart = 0, colEnd = matrix.GetLength(1) - 1;

  while (rowStart <= rowEnd && colStart <= colEnd)
  {
    // Заполнение верхней горизонтальной строки
    for (int col = colStart; col <= colEnd; col++)
    {
      matrix[rowStart, col] = count++;
    }
    rowStart++;

    // Заполнение правой вертикальной строки
    for (int row = rowStart; row <= rowEnd; row++)
    {
      matrix[row, colEnd] = count++;
    }
    colEnd--;

    // Заполнение нижней горизонтальной строки
    if (rowStart <= rowEnd)
    {
      for (int col = colEnd; col >= colStart; col--)
      {
        matrix[rowEnd, col] = count++;
      }
      rowEnd--;
    }

    // Заполнение левой вертикальной строки
    if (colStart <= colEnd)
    {
      for (int row = rowEnd; row >= rowStart; row--)
      {
        matrix[row, colStart] = count++;
      }
      colStart++;
    }
  }
}

void PrintMatrix(int[,] matrix)
{
  Console.WriteLine("Матрица заполняется змейкой:\n");
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j].ToString("00"),5} ");
    }
    Console.WriteLine("|");
  }
}
