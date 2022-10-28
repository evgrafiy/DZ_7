// Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

//пойдём другим путём

Console.WriteLine("Загадайте количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Представьте, сколько столбцов может быть: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,11));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Где ваше число? ");
    Console.WriteLine();
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Точнее! ");
 int b = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine();
 if (a>m && b>n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine(c);
 }

