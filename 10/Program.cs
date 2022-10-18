// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число число");
int num1 = int.Parse(Console.ReadLine()!);

if(num1 / 100 >= 1)
{
    if(num1 / 1000 < 1)
    {
    System.Console.WriteLine(num1 / 10 % 10);
    }
    else
    {
    System.Console.WriteLine("Введенное число не является трехначным");
    }
}
else
{
System.Console.WriteLine("Введенное число не является трехзначным");
}