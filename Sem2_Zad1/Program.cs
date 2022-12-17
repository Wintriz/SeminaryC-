// //Задача 1. Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит 
// остаток от деления.
Console.WriteLine("Enter first number: ");
int FirstNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter second number: ");
int SecondNumber = int.Parse(Console.ReadLine()!);

if (FirstNumber % SecondNumber == 0)
{
    Console.Write("Первое число кратно второму");
}
else
{
Console.Write("Вывод остатка: ");
Console.WriteLine(FirstNumber/SecondNumber);
}