// Напишите программу которая принимает координаты двух точек и находит расстояние между ними в 3д пространстве
//  

Console.WriteLine("Введите координату X первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y первой точки");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату z первой точки");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату x второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y второй точки");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y второй точки");
double z2 = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2 -z1, 2) );

Console.WriteLine(c);