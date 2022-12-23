// Задача 1: Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите суммы отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] array = new int[10];
int sum1 = 0;
int sum2 = 0;
for (int i = 0; i < array.Length; i++)
{

    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum1 = array[i] + sum1;

    }
}
Console.Write("Сумма положительных элементов: ");
Console.WriteLine(sum1);
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        sum2 = array[i] + sum2;
    }
}
Console.Write("Сумма отрицательных элементов: ");
Console.WriteLine(sum2);
Console.WriteLine();






// Задача 2: Задайте массив из 10 элементов из промежутка [-9, 9] и положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     int randomNumber = new Random().Next(-9, 10);
//     array[i] = randomNumber;
//     Console.WriteLine(array[i]);
// }
// Console.WriteLine();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * -1;
//     Console.WriteLine(array[i]);
// }




// Задача 3: Задайте массив из 8 случайных чисел из промежутка [-9, 9]. Напишите программу получает на вход число и определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(-9, 9);
//         index++;
//     }
// }

// void PrintArray(int[] coll)
// {
//     int count = coll.Length;
//     int pos = 0;
//     while (pos < count)
//     {
//         Console.Write(coll[pos] + " ");
//         pos++;
//     }

// }
// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine(" ");

// Console.WriteLine("Введите число: ");
// int zChislo = Convert.ToInt32(Console.ReadLine());
// int chisloEst = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == zChislo)
//     {
//         chisloEst++;
//     }
// }
// if (chisloEst > 0)
// {
//     Console.WriteLine($"Заданное число присутствует в массиве в колличестве {chisloEst}.");
// }
// else
// {
//     Console.WriteLine("Заданного числа в массиве нет.");
// }


// Задача 4: Задайте массив из 10 случайных чисел из промежутка [-100, 100]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// *Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10*

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0

// [10, 11, 12, 13, 14] -> 5

// void ArrayPrint (int[] a)
// {
// Console.Write("[");
// for (int i=0; i<a.Length-1; i++) Console.Write($"{a[i]}, ");
// Console.WriteLine($"{a[a.Length-1]}]");
// }
// int[] Array =new int[10];
// int count = 0;

// for (int i=0; i<Array.Length; i++)
// {
// Array[i] = new Random().Next(-100,101);
// }
// ArrayPrint(Array);
// Console.WriteLine("Найдем количество элементов массива из отрезка [10;99]");

// for (int i=0; i<Array.Length; i++)
// {
// if (Array[i]>=10&&Array[i]<=99)
// {count +=1;
// Console.WriteLine(Array[i]);
// }

// }
// Console.WriteLine("Таких элементов в массиве:" + count);