// задайте одномерный массив  из 123 случайных чисел
// найдите количество элементов массива значение которых в отрезке [10,99]

int length = ReadInt("Array length");
//int find = ReadInt("Find number");
int[] array = GetRandomArray(123, 0, 1000);
PrintArray(array);
Console.WriteLine();
int count = FindElements(array);
Console.WriteLine(count);


int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}


int[] GetRandomArray(int length, int minValue, int maxValue)// новый масси длинной ленгс
{
    int [] array = new int[length];
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



int FindElements(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
     {
        if ((array[i] >= 10) && (array[i] <= 99))
        {
                count++;
        }
       
    }
     return count;
}
