//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System.Text;

int length = ReadInt("Array length");
int[] array = GetRandomArray(length, 100, 1000);
int count = FindElements(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(count);


int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
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
//или (создание строк)..наверхy необходимо прописывать using System.Text;
// string GetArrayAsString(int[] array)
// {
//     StringBuilder sb = new StringBuilder(array.Length);
//     for (int i = 0; i < array.Length; i++)
//          {
//                sb.Append($"{array[i]}, ");
 //           }
//     return sb.ToString();
// }

int FindElements(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
     {
        if (array[i] % 2 == 0)
        {
                count++;
        }
       
    }
     return count;
}