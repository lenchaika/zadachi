// Задача 40: Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int a = ReadInt("Введите длину стороны А");
int b = ReadInt("Введите длину стороны В");
int c = ReadInt("Введите длину стороны С");

CheckTriangle(a, b ,c);


int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine()!);
}

void CheckTriangle(int a, int b, int c)
{
    if (a + b > c && b + c > a && a + c > b)
    {
        System.Console.WriteLine("Треугольник с такими сторонами существует");
    }
    else
    {
        System.Console.WriteLine("Треугольник с такими сторонами не существует");
    }
}
