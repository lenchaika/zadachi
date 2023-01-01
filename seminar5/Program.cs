// задача 31. задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]
// найдите сумму отриц и положит элементов массива

int minimalSum = 0;
int maximalSum = 0;
int length = ReadInt("Array length");
int[]array = GetRandomArray(length, -9, 9);

PrintArray(array);
CalculateSum(array);

Console.WriteLine($"Positive sum is {maximalSum}; Negativ sum is {minimalSum}");

int ReadInt(string argument)
{
    Console.Write($"Input{argument}");
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


void CalculateSum(int[]array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            minimalSum += array[i];
        }
        else
        {
            maximalSum += array[i];
        }
    }
   
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
