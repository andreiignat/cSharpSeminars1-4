// Напишите программу которая принимает на вход 5ти значное число и проверяет является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void ReadNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число палиндром.");
  }
  else 
    Console.WriteLine($"Ваше число НЕ палиндром.");
}

if (number!.Length == 5){
  ReadNumber(number);
}
else Console.WriteLine($"Введенное число не пятизначное");