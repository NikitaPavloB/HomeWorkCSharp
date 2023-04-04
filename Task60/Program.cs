// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Clear();

int[,,] matrix = CreateMatrix(2, 2, 3, 10, 99);

PrintMatrix(matrix);

// Метод для создания трехмерной матрицы заданной размерности, 
//заполненной случайными числами из заданного диапазона, где каждое число встречается ровно один раз.
static int[,,] CreateMatrix(int rows, int columns, int depth, int min, int max)
{
  int[,,] matrix = new int[rows, columns, depth];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        int num;
        bool contains;
        // Генерация случайного числа из заданного диапазона, пока это число уже не содержится в матрице.
        do
        {
          num = rnd.Next(min, max + 1);
          contains = Contains(matrix, num);
        } while (contains);
        // Запись полученного числа в текущий элемент матрицы.
        matrix[i, j, k] = num;
      }
    }
  }
  return matrix;
}

// Метод для проверки наличия заданного числа в трехмерной матрице
static bool Contains(int[,,] matrix, int num)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        if (matrix[i, j, k] == num)
        {
          // Если число найдено в матрице, возвращается значение true.
          return true;
        }
      }
    }
  }
  // Если число не найдено в матрице, возвращается значение false.
  return false;
}

// Метод для вывода трехмерной матрицы на консоль.
static void PrintMatrix(int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        // Выводим значение текущего элемента, а также его индексы.
        Console.Write($"{matrix[i, j, k],5} ({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
