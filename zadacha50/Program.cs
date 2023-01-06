// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int[,] array = GetArray(ReadInt("Length"),ReadInt("secondLength"));
int x = ReadInt("x");
int y = ReadInt("y");
PrintArray(array);


int ReadInt(string argument)
{
   Console.WriteLine($"Input {argument}");
   return int.Parse(Console.ReadLine()); 
}


int[,] GetArray(int length, int secondLength)
{
        int[,] array = new int[length, secondLength];
        Random random = new Random();
        for  (int i = 0; i < length; i++)  
        {
            for  (int j = 0; j < secondLength; j++) 
            {
                array[i, j] = random.Next(100);
            }
        } 
        return array;
}
void PrintArray(int[,] array)
{
        for  (int i = 0; i < array.GetLength(0); i++)  
        {
            for  (int j = 0; j < array.GetLength(1); j++) 
            {
                Console.Write($"{array[i, j]}  ");
            }
             Console.WriteLine();
        } 
        Console.WriteLine();
}

bool HasValue(int[,]array, int x, int y)
{
    if (x > 0 && y > 0 && x < array.GetLength(0) && y < array.GetLength(1))
    {
        return true;
    }
    return false;

}


if (HasValue(array, x, y))
{
    Console.WriteLine($"Elements is {array[x, y]}");
}
else
{
    Console.WriteLine("not element");
}