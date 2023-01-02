// Задача 40: Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int length = ReadInt("Array length");
int[] array = GetRandomArray(length, -9, 9);

PrintArray(array);
Revers(array);

Console.WriteLine();
PrintArray(array);

int ReadInt(string argument)
{
    Console.WriteLine($"Input {argument}:");
    return int.Parse(Console.ReadLine());
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

void Triangle(int[] array)
{
    if (array[0] + array[1] > array[2] && array[1] + array[2] > array[0] && array[0] + array[2] > array[1])
    {
        Console.Write(" This is Triangle");
    }
}