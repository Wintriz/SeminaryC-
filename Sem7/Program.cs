// Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3

// 1 2 3 4

// 2 3 4 5

int[,] array = new int [3,4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i +j;
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}


// Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:

// 1 4 7 2

// 5 9 2 3

// 8 3 2 9

// Новый массив будет выглядеть вот так:

// 1 4 49 2

// 5 9 2 9

// 64 3 4 9

void FillArray (int[, ]matr)
{
for (int i=0; i<matr.GetLength(0); i++)
{
for (int j=0; j<matr.GetLength(1); j++)
{
matr[i,j] = new Random().Next(1,10);
}
// Console.WriteLine();
}
}
void PrintArray (int[, ]matr)
{
for (int i=0; i<matr.GetLength(0); i++)
{
for (int j=0; j<matr.GetLength(1); j++)
{
Console.Write($"{matr[i, j]} ");
}
Console.WriteLine();
}
}
int [, ] matrix = new int [3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (i % 2 == 0 && j % 2 == 0)
{
matrix[i,j] = matrix[i,j] * matrix[i,j];
}
}
}
Console.WriteLine();
PrintArray(matrix);



void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i, j] = new Random().Next(1, 10);
}
// Console.WriteLine();
}
}
void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($"{matr[i, j]} ");
}
Console.WriteLine();
}
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (i % 2 == 0 && j % 2 == 0)
{
double x = Math.Pow(matrix[i, j], 2); // получение квадрата с типом данных dobule
matrix[i, j] = Convert.ToInt32(x); // изменение типа данных с double на int
}
}
}
Console.WriteLine();
PrintArray(matrix);