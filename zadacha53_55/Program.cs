// задайте двумерный массив .напишите программу которая поменяет местами первую и последнюю сроку массива

//Task53();
Task55();
// void Task53()
// {
//      int[,]array = GetTwoDimensionArray(ReadInt("First Length"), ReadInt("Second Length"));
//      PrintArray(array);
//      ChangeFrirstAndLastRow(array);
//      PrintArray(array);
//  }

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

void PrintArray (int[,] array)
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

int[,] GetTwoDimensionArray(int firstLength, int secondLength)
 {
     int[,] array = new int[firstLength, secondLength]; 
     Random random = new Random();
     for (int i = 0; i < firstLength; i++)
     {
         for (int j = 0; j < secondLength; j++)
         {
             array[i, j] = random.Next(100);  
        }
     }
     return array;
 }


//  void ChangeFrirstAndLastRow(int[,] array)
//  {
//      int[] firstRow = GetFirstRow(array); 
//      PutLastRowOnFirstRow(array);
//     PutFirstRowOnLastRow (array, firstRow);       
//  } 

//  int[]GetFirstRow(int[,] array)
//  {
//      int[] tempArray = new int[array.GetLength(0)];
//              for (int i = 0; i < array.GetLength(1); i++)
//          {
//              tempArray[i] = array[0, i]; // копируем первую срочку
//          }

//     return tempArray;
//  }

//  void PutLastRowOnFirstRow(int[,] array)
//  {
//      int lastRowIndex = array.GetLength(0) - 1;
//      for (int i = 0; i < array.GetLength(1); i++)
//      {
//          array[0, i] = array[lastRowIndex, i];
//      }
//  }


//  void PutFirstRowOnLastRow(int[,] array, int[] firstRow)
//  {
//      int lastRowIndex = array.GetLength(0)-1;
//      for (int i = 0; i < array.GetLength(1); i++)
//      {
//          array[lastRowIndex, i] = firstRow[i];
//      }
//  }


//void Task55()// задать двумерный массив.программа заменяет строки на столбцы.если не возмодно должна вызвать сообщение

void Task55()
{
    int[,] array = GetTwoDimensionArray(ReadInt("First Length"), ReadInt("Second Length"));
    PrintArray(array);
    if (!IsPossibleToChangeRowToColumns(array))//строки короче чем столбцы.если это не так
    {
        Console.WriteLine("Incorrect array");//то массив неверный и заканчиваем выполнение функций
        return;
    }
    int[,] copy = Copy(array);//копируем масссив
    for (int i = 0; i < array.GetLength(0); i++)
    {
        ChangeRowOnColumn(array, copy, i);
    }
    PrintArray(array);
}

 bool IsPossibleToChangeRowToColumns(int[,] array)
    {
        return array.GetLength(0) < array.GetLength(1);
    }

int[] GetRow(int[,] array, int rowNumber)
{
    int[] tempArray = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
        {
            tempArray[i] = array[rowNumber, i]; // копируем первую срочку
        }

    return tempArray;
}

void ChangeRowOnColumn(int[,] array, int[,] copy, int row)//передаем три аргумента - роу это индекс
{
    int[] changebalRow = GetRow(copy, row);//получаем строку из копии
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if(i < changebalRow.Length)//проверяем 
        {
        array[i, row] = changebalRow[i];//меняем по срокам меняем значения
        }
        else
        {
            
            array[row, array.GetLength(1) - (array.GetLength(1) - i)] = 0;//но если не так меняем столбцы
        }
    }
}

int[,] Copy(int[,] array)
{
    int[,] copy = new int [array.GetLength(0), array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            copy[i, j] = array[i, j];
        }
        }
        return copy;
}