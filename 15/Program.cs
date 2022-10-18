//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер день недели");
int num1 = int.Parse(Console.ReadLine()!);

if(num1 < 8)
{
    if(num1 < 6)
    {
    System.Console.WriteLine("нет");
    }
    else
    {
    System.Console.WriteLine("Да");
    }
}
else
{
System.Console.WriteLine("Введенного дня недели не существует");
}
