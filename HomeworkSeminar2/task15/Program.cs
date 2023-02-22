// Console.WriteLine("Введите  число");
// int n1 = Convert.ToInt32(Console.ReadLine());
// if(n1 > 99 && n1 <1000)
// {
//     int n2 = (n1 / 100)%10;
//     Console.WriteLine(n2);
// }
// if(n1 < 99)
// {

//     Console.WriteLine("Нет третьей цифры");
// }	

Console.Write("Ввдите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}