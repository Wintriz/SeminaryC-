//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.

// Console.Clear();
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(1, n));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return end.ToString();
//     return (start + " " + PrintNumbers(start + 1, end)); // "3  2  1"
// }


// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int n = int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(n, 1));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return end.ToString();
//     return (start + " " + PrintNumbers(start - 1, end));
// }


// Задача 2: Задайте значение N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от 1 до N.

// M = 1; N = 15 -> 120

// int m = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine(PrintNumbers(m, n));

// int PrintNumbers(int start, int end)
// {
//     if (start == end) return end;
//     return (start + PrintNumbers(start + 1, end));
// }