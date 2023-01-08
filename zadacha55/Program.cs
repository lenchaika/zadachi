//  задать двумерный массив.программа заменяет строки на столбцы.если не возмодно должна вызвать сообщение

int[] array = GetArray(ReadInt());

PrintArray(array);

string[,] dictionary = GetDictionary(array);

PrintToDimensionArray(dictionary);

int ReadInt()
{
	return int.Parse(Console.ReadLine());
}

int[] GetArray(int length)
{
	int[] array = new int[length];
	Random r = new Random();

	for (int i = 0; i < length; i++)
	{
		array[i] = r.Next(10);
	}

	return array;
}

string[,] GetDictionary(int[] array)
{
	string[,] dictionary = new string[array.Length, 2];
	int position = 0;

	for (int i = 0; i < array.Length; i++)
	{
		int index = GetIndex(dictionary, array[i].ToString());

		if (index != -1)
		{
			dictionary[index, 1] = (int.Parse(dictionary[index, 1]) + 1).ToString();
		}
		else
		{
			dictionary[position, 0] = array[i].ToString();
			dictionary[position, 1] = 1.ToString();
			position++;
		}
	}

	return dictionary;
}

int GetIndex(string[,] array, string value)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		if (array[i, 0] == value)
		{
			return i;
		}
	}

	return -1;
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} ");
	}

	Console.WriteLine();
}

void PrintToDimensionArray(string[,] array)
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
