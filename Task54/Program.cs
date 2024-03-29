﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int[,] matrix = CreateMatrixRndInt(4, 5, 0, 15);
Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);
Console.WriteLine();

int[,] result = ElementsDescending(matrix);
Console.WriteLine("Массив с упорядоченными элементами по убыванию:");
PrintMatrix(result);

int[,] ElementsDescending(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    // применяем пузырьковую сортировку к i-й строке массива
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
      for (int k = j + 1; k < matrix.GetLength(1); k++)
      {
        if (matrix[i, j] < matrix[i, k])
        {
          // меняем местами элементы, если они не упорядочены по убыванию
          int temp = matrix[i, j];
          matrix[i, j] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
  return matrix;
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