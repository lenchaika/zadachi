// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.45 -> 101101/3 -> 11/2 -> 10


int ReadInt(string argument)
{
    Console.WriteLine($"Input {argument}:");
    return int.Parse(Console.ReadLine());
}

int i = ReadInt("N");
Console.WriteLine(ConvertToBinary(i));
string ConvertToBinary(int i)
{
    string result = string.Empty;

    while (i > 0)
    {
        result += i % 2;
        i /= 2;
    }
    return result;
}


