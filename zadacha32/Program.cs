// напишите  программу  замена  элементов массива положительные элементы замените на соответсвующие  отрицательные и наоборот


int length = ReadInt("Array length");
int[] array = GetRandomArray(length, -15, 15);
PrintArray(array);
Console.WriteLine();
ReversArray(array);
PrintArray(array);

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


void ReversArray(int[]array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        
        {
            array[i] = -array[i];
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
