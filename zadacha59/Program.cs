// задайте двумерный массив из целых чисел. напишите программу.которая удалит строку и столбец 
//на пересечениикоторых расположен наименьший элемент массива.

int[,] array = GetTwoDimensionArray(5, 5);
PrintArray(array);
int[,] newArray = GetNewArray(array);
PrintArray(newArray);

int[,] GetTwoDimensionArray(int length, int length2)
{
	int[,] array = new int[length, length2];

	Random r = new Random();

	for (int i = 0; i < length; i++)
	{
		for (int j = 0; j < length2; j++)
		{
			array[i, j] = r.Next(10);
		}
	}

	return array;
}

int[,] GetNewArray(int[,] array)
{
	int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
	int[] minimalRowAndColumn = GetMinimalRowAndColumn(array);

	int newArrayIndexRow = 0;
	int newArrayIndexColumn = 0;

	for (int i = 0; i < array.GetLength(0); i++)
	{
		if (i != minimalRowAndColumn[0])
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (j != minimalRowAndColumn[1])
				{
					newArray[newArrayIndexRow, newArrayIndexColumn] = array[i, j];
					newArrayIndexColumn++;
				}
			}
			newArrayIndexColumn = 0;
			newArrayIndexRow++;

		}
	}

	return newArray;
}

int[] GetMinimalRowAndColumn(int[,] array)
{
	int[] rowAndColumn = new int[2];
	int minimalValue = array[0, 0];

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (array[i, j] < minimalValue)
			{
				minimalValue = array[i, j];
				rowAndColumn[0] = i;
				rowAndColumn[1] = j;
			}
		}
	}

	return rowAndColumn;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine();
	}

	Console.WriteLine();
}
