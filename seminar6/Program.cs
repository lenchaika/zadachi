// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

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

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int number = ReadInt("number");
Transform(number);


int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine()!);
}

void Transform(int number)
{
    string result = string.Empty;
    while (number != 0)
    {
        result += number % 2;
        number /= 2;        
    }
    string Reverse(string result)
    {
        char [] array = result.Reverse().ToArray();
        string new_result = string.Empty;
        foreach(char c in array)
        {
            new_result += c;
        }
        return new_result;
    }

    System.Console.WriteLine(Reverse(result));
}


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int N = ReadInt("N");
Fibonacci(N);

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine()!);
}

void Fibonacci(int N)
{
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < N; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    PrintArray(array);
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}


// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int length = ReadInt("Array length");
int[] array = GetRandomArray(length, 0, 10);

PrintArray(array);
Console.WriteLine();
PrintArray(Copy(array));

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine()!);
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
	int[] array = new int[length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

int[] Copy(int[] array)
{
    int[] array_copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array_copy[i] = array[i];
    }
    return array_copy;
}
