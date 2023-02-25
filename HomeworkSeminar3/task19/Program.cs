// Напишите программу которая принимает на вход 5ти значное число и проверяет является ли оно палиндромом.

// Console.Write("Введите пятизначное число: ");
// string? number = Console.ReadLine();

// void ReadNumber(string n)
// {
//   if (n[0]==n[4] && n[1]==n[3])
//   {
//     Console.WriteLine($"Ваше число палиндром.");
//   }
//   else 
//     Console.WriteLine($"Ваше число НЕ палиндром.");
// }

// if (number!.Length == 5)
// {
//   ReadNumber(number);
// }
// else Console.WriteLine($"Введенное число не пятизначное");

int ReadNumber(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

int n = ReadNumber("Введите пятизначное число");
int r, t, s = 0;
t = n;

if (n > 9999 || n > 99999)
  {
    while (n > 0)
    {
    r = n % 10;
    s = (s*10)+r;
    n = n/10;
    }
    if (t==s)
    {
      Console.WriteLine($"это число {t} палиндром");
    }
    else
    {
      Console.WriteLine("это число НЕ палиндром");
    }
  } 
  else 
  {
    Console.WriteLine("Введено не верное число");
  }
