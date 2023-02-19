// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = Random.Shared.Next (100, 1000);
Console.WriteLine(number);
int LastDigit = number % 10;
int FirstDigit = number / 100;
int res = FirstDigit * 10 + LastDigit;
Console.WriteLine(res);
