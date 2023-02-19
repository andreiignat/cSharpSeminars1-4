// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.WriteLine("Введите число");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int n2 = Convert.ToInt32(Console.ReadLine());
int res = n1 % n2;
if( res != 0)
{
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Второе число кратное первому");
}