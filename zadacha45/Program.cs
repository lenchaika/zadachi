//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
 int length = ReadInt("Array length");
    int[] array = GetRandomArray(length, 1, 10);
    PrintArray(array);
    Console.WriteLine();
    PrintArray(Clone(array));
 
int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
	int[] array = new int[length];
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
		Console.Write($"{array[i]}  ");
	}
}
int[] Clone(int [] array)
{ int[] new_array= new int [array.Length];
for (int i = 0; i < array.Length; i++)
	{
	    new_array[i] = array[i];
	}

	return new_array;
}
