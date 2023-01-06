// задайте двумерный массив. найдите элементы  у которых оба индекса четные и замените эти элементы на их квадаты
//1472  //1472
//5923  //58129
//8424  //8424

int firstLength = ReadInt("first length");
int secondLength = ReadInt("second length");

int[,] firstArray = GetArray(firstLength, secondLength);
PrintArray(firstArray);
System.Console.WriteLine();
PrintArray(FindElementsWithEvenIndex(firstArray));
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

int[,] FindElementsWithEvenIndex (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            if (i % 2 == 0 && j % 2 == 0) 
            {
                array[i,j] = array[i,j] * array[i,j];
            }
        }
    }
    return array;
}
