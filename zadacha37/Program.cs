// найти произведение  пар чисел в одномерном массиве . парой считаем первый и последний элемент ,второй и предпоследний и т.д.
//результат в новом массиве


//int length = ReadInt("Array length");
//int find = ReadInt("Find number");
int[] array = GetRandomArray(9, 0, 50);
PrintArray(array);
Console.WriteLine();
int[] newarray = NewArray(array);
PrintArray(newarray);



int[] GetRandomArray(int length, int minValue, int maxValue)// новый массив длинной ленгс
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



int [] NewArray(int[] array)

{
    int [] newarray = new int[(array.Length / 2) + 1];
    for (int i = 0; i < array.Length/2; i++)
    {
         newarray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
    newarray[(array.Length/2) - 1] = array[array.Length/2];
    return newarray;
}