// Задача 50.  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Clear();

int[,] matrix = CreateMatrixRndInt(5, 5, -10, 10);

Console.Write("Введите номер строки: ");
int rowIndex = Convert.ToInt32(Console.ReadLine()) - 1;  // -1, чтобы номер строки начинался с 0
Console.Write("Введите номер столбца: ");
int columnIndex = Convert.ToInt32(Console.ReadLine()) - 1;  // -1, чтобы номер столбца начинался с 0

// Ищем элемент с заданными номерами и выводим его значение или указание об отсутствии элемента
string elementValue = GetMatrixElementValue(matrix, rowIndex, columnIndex);

Console.WriteLine();
PrintMatrix(matrix);

Console.WriteLine();
Console.WriteLine(elementValue);

string GetMatrixElementValue(int[,] matrix, int rowIndex, int columnIndex)
{
  if (rowIndex < 0 || rowIndex >= matrix.GetLength(0) || columnIndex < 0 || columnIndex >= matrix.GetLength(1))
  {
    return "Такого элемента в массиве нет";
  }
  else
  {
    return $"Значение элемента в массиве: {matrix[rowIndex, columnIndex]}";
  }
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
      Console.Write($"{matrix[i, j],4} ");
    }
    Console.WriteLine("|");
  }
}
