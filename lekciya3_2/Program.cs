//1. Найти позицию минимального элемента в неотсортированной части массива.
//2. Произвести обмен этого значения со значением первой неотсортированной позиции.
//3. Повторять пока есть неотсортированные элементы.

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
//вывести массив на экран
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;//определение позиции на которую смотрим
        //ищем минимальный элемент
            for(int j = i + 1; j < array.Length; j++)
                {
                      if(array[j] < array[minPosition]) minPosition = j;     
                }

        //меняем позиции местами
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;  

    }
}
PrintArray(arr);
SelectionSort(arr);


PrintArray(arr);