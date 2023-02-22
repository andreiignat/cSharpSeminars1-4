// Напишите программу которая принимает на вход число N и выдает таблицу кубов.

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= n)
{
    double c = Math.Pow(index, 3);
    index++;
    Console.WriteLine(c);
}
