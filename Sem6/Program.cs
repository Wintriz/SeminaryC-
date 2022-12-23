// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

int[] array = new int[4];
int[] array2 = new int[4];
for (int i = 0; i < array.Length; i++)
{

    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i] + " ");
    
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
array2[i] = array[array.Length - 1 - i];
Console.Write(array2[i] + " ");
}

// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10

// [1, -5, 8, 4, -9] -> 4.33

написать начало самому


or (int i=0; i<length; i++) 
{
Array[i] = new Random().Next(-10,11);
}
ArrayPrint(Array);

for (int i=0; i<length; i++) 
{
    if (Array[i]>0)
    {
       count +=1;
       sum += Array[i];
    }
}
Console.Write("Сумма положительных элементов: " + Convert.ToDouble(sum)/count);




// Задча 3. Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12


Console.WriteLine("Введите количество строк: ");
int lines = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = new int[lines, columns];

int sum = 0;

// Заполнение двумерного массива:
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-10, 11);
    }
}
// Вывод двумерного массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
// Вариант 1
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i == j) {
//             sum = sum + array[i, j];
//         }
//     }
// }

// Вариант 2

int minLength = array.GetLength(0); // 4
if (array.GetLength(1) < minLength)
{
    minLength = array.GetLength(1);
}

for (int i = 0; i < minLength; i++)
{
    sum = sum + array[i, i];
}

Console.WriteLine($"Сумма элементов главной диагонали: {sum}");
