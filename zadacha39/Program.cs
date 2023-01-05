//напишите программу которая первернет ономерный массив (последний элемент будет на первом. а первый на последнем)

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

void Revers(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
