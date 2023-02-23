// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.


// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// int index = 0;

// while (index <= n)
// {
//     double c = Math.Pow(index, 3);
//     index++;
//     Console.WriteLine(c);
// }

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N = ReadNumber("Введите число");
for(int i = 1; i < N; i++)
{
    Console.Write(i * i + ", ");
}
Console.WriteLine(N * N + ".");
