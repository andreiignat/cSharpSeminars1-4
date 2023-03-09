// Напиишите программу которая принимает на вход А и В и возводит А в степень В.
//3,5  = 243.

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int sum = 1;

int Method(int n1, int n2)
{
        for(int i=0; i < n2; i++ )
        {
            sum *= n1; 
        }
    return sum;

}
 
int num1 = ReadNumber("Введите число А");
int num2 = ReadNumber("Введите число Б");

Console.WriteLine($"{num1} возвели в степень {num2} получили {Method(num1, num2)}");