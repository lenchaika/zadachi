// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int length = ReadInt("Array length");
double[] array = GetRandom(length, 0, 100);
PrintArray(array);
Console.WriteLine();
DifferentMaxMin(array);


int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}


double[] GetRandom(int length, int minValue, int maxValue)
{
    double [] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue) + random.NextDouble();
    }
    return array;
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)} ");
    }
}



void DifferentMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
          
        }
        if (array[i] < min)
        {
            min = array[i];
           
        }
    }
    Console.WriteLine(max);
    Console.WriteLine(min);

}
