// Задача 2. Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Enter a number: ");
int entNumber = int.Parse(Console.ReadLine()!);
int firNum = 7;
int secNum = 23;
if(entNumber % firNum == 0 && entNumber % secNum == 0)
{
    Console.Write("Введеное число кратно числам: ");
    Console.Write(firNum);
    Console.Write(" и ");
    Console.Write(secNum);
}
else
{
Console.WriteLine("Введеное число не кратно заданным числам");
}