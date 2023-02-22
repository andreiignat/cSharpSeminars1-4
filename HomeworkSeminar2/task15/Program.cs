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

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while(number > 999)
    {
        number /= 10;
    }
    return number % 10;

}
 bool ValidateNumber(int number)
 {
    if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
 }

 int number = Prompt("Введите число > ");
 if (ValidateNumber(number))
 {
    Console.WriteLine(GetThirdRank(number));
 }