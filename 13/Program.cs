//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int GetThreedigit(int number)
{
    if (number < 1000)
    {
    int ThreeDigit = number % 10;
    return ThreeDigit;
    }
    else 
    {
        while(number > 999)
            number = number/10;
        int ThreeDigit = number % 10;
        return ThreeDigit;
    }
}
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
if (number < 100)
Console.WriteLine("третьей цифры нет");
else
{
int ThreeDigit = GetThreedigit(number);
Console.WriteLine(ThreeDigit);
}