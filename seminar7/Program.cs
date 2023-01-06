// двумерный массив с разером mXn,заполненный случайными целыми числами
// создать массив
// создать читатель чисел - 2 длинны массива
// создать фуекцию заполняющую массив
// внутри функции заполняем слчайными числами целыми
// создать функцию выводящую массив на экран

int length = ReadInt();
int secondLength = ReadInt();
int[,] array = GetArray(length, secondLength);
PrintArray(array);
Console.ReadLine();

int ReadInt()
{
   return int.Parse(Console.ReadLine()); // возвращает число в строку
}

// создать функцию заполняющую массив ,внутри функции заполняем слчайными числами целыми

int[,] GetArray(int length, int secondLength)// длина массива первого и второго измерения
{
        int[,] array = new int[length, secondLength];
        Random random = new Random();
        for  (int i = 0; i < length; i++)  
        {
            for  (int j = 0; j < secondLength; j++) 
            {
                array[i, j] = random.Next(1000);
            }
        } 
        return array;
}
// создать функцию выводящую массив на экран
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
}