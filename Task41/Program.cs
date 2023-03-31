// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

int[] EternNumbers (int n)
{
    int[] arr = new int[n];
    Console.WriteLine("Введите числа");
    for (int i = 0; i < n; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountNumbers (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}


void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

Console.WriteLine("Введите количество чисел для ввода");
int m = Convert.ToInt32(Console.ReadLine());
int[] eternNumbers = EternNumbers(m);
int countNumbers = CountNumbers(eternNumbers);
Console.WriteLine();
PrintArray(eternNumbers);
Console.WriteLine($" -> {countNumbers}");