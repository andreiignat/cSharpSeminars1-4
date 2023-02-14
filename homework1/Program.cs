Console.WriteLine("введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max=" + a + "min=" + b);
}
else
{
    Console.WriteLine("max=" + b + "min=" + a);
}