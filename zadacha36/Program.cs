// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.



int length = ReadInt("Array length");
int[]array = GetRandomArray(length, 1, 100);
int result = 0;
FindSum(array);
PrintArray(array);


int ReadInt(string argument)
{
    Console.Write($"Input{argument}");
    return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
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


void FindSum(int[]array)
{
       
    for (int i = 0; i < array.Length; i++)
     {
        if ((array[i]+1) % 2 != 0)
        {
               result += array[i]; 
        }
       
    }
    Console.WriteLine(result);
}



