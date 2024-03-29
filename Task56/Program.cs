﻿// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
Console.WriteLine("Матрица:\n ");
PrintMatrix(matrix);

int minRow = FindRowWithMinSum(matrix);
Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minRow + 1}");

int FindRowWithMinSum(int[,] matrix)
{
  int minRowIndex = 0;
  int minRowSum = int.MaxValue;

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int rowSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      rowSum += matrix[i, j];
    }
    if (rowSum < minRowSum)
    {
      minRowSum = rowSum;
      minRowIndex = i;
    }
  }

  return minRowIndex;
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
      Console.Write($"{matrix[i, j],5} ");
    }
    Console.WriteLine("|");
  }
}