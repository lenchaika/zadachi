// напишите программу которая будет принимать на вход число и возвращать сумму его цифр
//453 ->12
//45->9

int SumNumbers(int number)
{
    if (number / 10 == 0)
    {
        return number % 10;
    }
    return number % 10 + SumNumbers(number/10);
}
Console.WriteLine(SumNumbers(451));


