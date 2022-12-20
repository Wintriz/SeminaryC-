// Задача 1:
// Напишите программу, которая принимает на вход число N и выдаёт сумму чисел от 1 до N.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Write("Введите число N ");
// int N = int.Parse(Console.ReadLine());
// int sum = 0;
// for (int i=1; i<=N; i++) 
// {
// sum=sum+i;
// }
// Console.Write(sum);


// Задача 2:
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

// Console.Write("Введите число N ");
// int N = int.Parse(Console.ReadLine());

// int G (int a)
// {
//       int sum = 1;  
//          for (int i=1; i<=a; i++) sum=sum*i;
         
// return sum;
// }

// Console.Write(G(N));


// Задача 3 (общая):
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] Array =new int[8];
// for (int i=0; i<Array.Length; i++) 
// {
    
// Array[i] = new Random().Next(0,2);
// Console.Write(","+Array[i]);

// }

// красивый вывод массива
// for (int i = 0; i < array.Length; i++)
// {
//     if (i == array.Length - 1)
//     {
//         Console.Write(array[i] + ".");
//     }
//     else 
//     {
//         Console.Write(array[i] + ", ");
//     }
// }
