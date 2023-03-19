// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double Distance(int x1, int y1, int d1, int x2, int y2, int d2)
{
  int x = x1 - x2;
  int y = y1 - y2;
  int d = d1 - d2;
  double c = Math.Sqrt(x * x + y * y + d * d);
  return c;
}

Console.WriteLine("Введите координаты первой точки по X:");
int num1X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по Y:");
int num1Y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по D:");
int num1D = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по Y:");
int num2X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по X:");

int num2Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по D:");
int num2D = Convert.ToInt32(Console.ReadLine());

double result = Distance(num1X, num1Y, num1D, num2X, num2Y, num2D);
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками равно {resRound}");