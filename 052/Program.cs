// Задача 52
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int srAr = 0;
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 11));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}

for (int i = 0; i < 3; i++)
{
    for (int t = 0; t < 3; t++)
    {
        srAr += array[t, i];
    }
    Console.WriteLine();
    Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr / 3}");
}

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Загадайте число строк: ");
//         int m = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Представьте, сколько столбцов может быть: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         int[,] massive = new int[m, n];
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 massive[i, j] = new Random().Next(-10, 10);
//                 Console.Write(massive[i, j] + " ");
//             }
//             Console.WriteLine();
//         }

//         double result = 0;

//         for (int j = 0; j < n; j++)
//         {
//             result = Average(j);
//             Console.WriteLine(result);
//         }

//         double Average(int column)
//         {
//             double average = 0;
//             double x = 0;
//             for (int i = 0; i < m; i++)
//             {
//                 average += massive[i, column];
//             }
//             x = average / m;
//             return x;
//         }
//     }
// }