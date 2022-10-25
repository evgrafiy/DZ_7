// Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

//пойдём другим путём

Console.WriteLine ("Введите число строк: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите число столбцов: ");
int n = Convert.ToInt32 (Console.ReadLine());
int[,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next (-10, 10);
        Console.Write (array[i,j]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine ("Введите строку элемента: ");
int row = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите столбец элемента: ");
int column = Convert.ToInt32 (Console.ReadLine());
if (row < m && column < n) Console.WriteLine ("Элемент массива с такими позициями существует: "+array[row,column]);
else Console.WriteLine ("Элемент массива с такими позициями не существует");




// Console.Write("Массив позаимствуем в (№ 47) задаче. Будет интересно.");
// Console.Write("Начните вводить через запятую позиции элемента: ");
// string? positionElement = Console.ReadLine();
// positionElement = RemovingSpaces(positionElement);
// int[] position = ParserString(positionElement);
// int[,] array = new int [m,n];

// if (position[0] <= m
// && position[1] <= n
// && position[0] >= 0
// && position[1] >= 0)
// {
//     double result = array[position[0] - 1, position[1] - 1];
//     Console.Write($"Значение элемента: {result}");
// }
// else Console.Write($"такого элемента в массиве нет.");
// int[] ParserString(string input)
// {
//     int countNumbers = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//             countNumbers++;
//     }

//     int[] numbers = new int[countNumbers];

//     int numberIndex = 0;
//     for (int i = 0; i < input.Length; i++)
//     {
//         string subString = String.Empty;

//         while (input[i] != ',')
//         {
//             subString += input[i].ToString();
//             if (i >= input.Length - 1)
//                 break;
//             i++;
//         }
//         numbers[numberIndex] = Convert.ToInt32(subString);
//         numberIndex++;
//     }

//     return numbers;
// }
// string RemovingSpaces(string input)
// {
//     string output = String.Empty;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] != ' ')
//         {
//             output += input[i];
//         }
//     }
//     return output;
// }