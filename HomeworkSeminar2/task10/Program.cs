
Console.WriteLine("Введите трехзначное число");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = n1 % 100;
int SecondDigit = n2 / 10;
Console.WriteLine(SecondDigit);