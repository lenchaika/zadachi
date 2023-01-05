// задайте массив.напишите программу которая определяет присутствует  ли заданное число в массиве.
// 4 массив [6,7,19,345,3] нет


int length = ReadInt("Array length");
int find = ReadInt("Find number");
int[] array = GetRandomArray(length, -15, 15);
PrintArray(array);
Console.WriteLine();
FindNumber(array, find);
ReversArray(array);


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

void FindNumber(int[] array, int findNumber)
{
    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] == find)
        {
            Console.WriteLine("Yes");
            return;
        }
        
    }
    Console.WriteLine("No");
}
