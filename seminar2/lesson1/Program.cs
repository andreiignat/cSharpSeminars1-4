// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8
int number = Random.Shared.Next (10, 100);
Console.WriteLine(number);
int LastDigit = number % 10;
int FirstDigit = number / 10;
if (LastDigit > FirstDigit)
{
    Console.WriteLine ($"max {LastDigit}, min {FirstDigit}");
}
else
{
   Console.WriteLine ($"max {FirstDigit}, min {LastDigit}");
}