// Задача 3. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Enter a number");
int N = int.Parse(Console.ReadLine()!);
int index = N * -1;
while (index < N)
{
    Console.Write(index);
    index++;
}