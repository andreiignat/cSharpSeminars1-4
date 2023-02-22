// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите первую координату х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координату y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Координаты в первой четверти");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Координаты во второй четверти");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Координаты в третей четверти");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Координаты в четвертой четверти");
}
else
{
    Console.WriteLine("невозможно определить координатную четверть");
}