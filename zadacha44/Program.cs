//Задача 44
int N = ReadInt("number");

Console.WriteLine(ArrayToString(GetArray(N)));

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int[] GetArray(int length)
{
	int[] array = new int[length];
    array[0] = 0;
    array[1] = 1;
	for (int i = 2; i < array.Length; i++)
	{
		array[i] = array[i-1] + array[i-2];
	}

	return array;
}
string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]}, ";
	}

	return result;
}
