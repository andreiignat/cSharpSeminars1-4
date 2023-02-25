// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
 int ReadNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()); 
    // int value = Convert.ToInt32(Console.ReadLine());
    // return value;   2 способа записи.
}

int CheckLength(int number)
{ 
    int count;
    for(count = 0; number !=0; count++ )
    {
        // number /=10; короткая запись  
        number = number / 10;
    }
    return count;

}

 int Usernumber = ReadNumber("введите число");
 int result = CheckLength(Usernumber);
 Console.WriteLine(result);
