// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Выполнить с помощью рекурсии

void PrintFromUntil(int m, int n)
{
    if (m >= n)
    {
        Console.WriteLine(m);
        return;
    }
    Console.Write($"{m}, ");
    PrintFromUntil(m+1, n);
}
PrintFromUntil(1, 5);
