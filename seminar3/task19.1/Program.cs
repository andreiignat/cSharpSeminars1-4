// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int index = 0;

while (index <= n)
{
    double c = Math.Pow(index, 3);
    index++;
    Console.WriteLine(c);
}
