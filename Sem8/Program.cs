// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4

// 5 9 2 3

// 1 4 7 2


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 11);
        }
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
int[,] matrix = new int[3, 5];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// меняем местами первую и последнюю строку
//for (int i = 0; i < matrix.GetLength(1); i++)
//{
//    int temp = matrix[0, i];
//    matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//    matrix[matrix.GetLength(0) - 1, i] = temp;
//}

// меняем местами первый и последний столб 
//for (int j = 0; j < matrix.GetLength(0); j++)
//{
//    int temp = matrix[j, 0];
//    matrix[j, 0] = matrix[j, matrix.GetLength(1) - 1];
//    matrix[j, matrix.GetLength(1) - 1] = temp;
//}
Console.WriteLine();
PrintArray(matrix);


// Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 удалить строку и столбец, на пересечении которых расположен наименьший элемент.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 11);
        }
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
int[,] matrix = new int[3, 5];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// меняем местами первую и последнюю строку
//for (int i = 0; i < matrix.GetLength(1); i++)
//{
//    int temp = matrix[0, i];
//    matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//    matrix[matrix.GetLength(0) - 1, i] = temp;
//}

// меняем местами первый и последний столб 
//for (int j = 0; j < matrix.GetLength(0); j++)
//{
//    int temp = matrix[j, 0];
//    matrix[j, 0] = matrix[j, matrix.GetLength(1) - 1];
//    matrix[j, matrix.GetLength(1) - 1] = temp;
//}
Console.WriteLine();
PrintArray(matrix);