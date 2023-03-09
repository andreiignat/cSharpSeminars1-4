// Напишите программу которая принимает число и выводит сумму цифр из которых оно состоит.

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int sum = 0;

int SumNumber(int num)
{
    while(num > 0)
    {
        sum = sum + num %10;
        num = num /10;
    }
    return num;
}

int number = ReadNumber("введите число");
Console.WriteLine(SumNumber(number));