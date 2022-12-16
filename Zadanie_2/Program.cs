// Задача 2 Даны два числа. Показать большее и меньшее число
Console.WriteLine("Enter a number a: ");
Console.WriteLine("Enter a number b: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int max = 0;
int min =0;
if(a > b)
{
    max = a;
    min = b;
    Console.WriteLine("max: ");
Console.WriteLine(a);
    Console.WriteLine("min: ");
Console.WriteLine(b);    
}

else
{
    max = b;
    min = a;
    Console.WriteLine("max: ");
Console.WriteLine(b);
    Console.WriteLine("min: ");
Console.WriteLine(a);
}


