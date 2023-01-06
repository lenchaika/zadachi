// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int firstLength = ReadInt("first length");
 int secondLength = ReadInt("second length");
int[,] array = GetArray(firstLength, secondLength);
PrintArray(array);
FindMiddle(array);
Console.WriteLine();


int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine()!);
}

int[,] GetArray (int length, int secondLength)
{
    int[,] array = new int[length, secondLength]; 
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(10);  
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindMiddle(int[,] array)
{
     Console.WriteLine($"Среднее арифметическое каждого столбца");
     for (int i = 0; i < array.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ += array[j, i];
        }
        Console.Write($"{summ/array.GetLength(0)} ");
    }
} 

