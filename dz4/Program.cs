Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input command: ");
        switch (Console.ReadLine())
        {
            case "Task25": Task25(); break;
            case "Task27": Task27(); break;
            case "Task29": Task29(); break;
            case "exit": isWorking = false; break;
        }
         Console.WriteLine();
    }
}
void Task25() // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    {
        Console.WriteLine("Task25");
        Console.Write("Введите число   : ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Введите степень : ");
        int n = int.Parse(Console.ReadLine());

       Console.WriteLine($"The power {num} of number {n} is {Pow(n, num)}");
    }


    void Task27()//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    {
        Console.WriteLine("Task27");
        int number = ReadInt ("number");
        Console.WriteLine(GetSum(number));
      }

void Task29()//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
{
    Console.WriteLine("Task29");
    int[] array = GetArray(ReadInt("array length"));
    
    
    Console.WriteLine(ArrayToString(array));
}


int Pow(int num, int n)// функция в степень
{
    int result = 1;
    for (int i = 0;  i < n; i++)
    {
        result *= num;
    }
    return result;
}

int ReadInt(string argumentName)// функция ввода числа
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine()); // возвращает от пользователя
}

 int GetSum(int n) // функция суммы 
 {
    int sum = 0;
    
    for (int i = n; i > 0; i = i / 10)
    {
        sum = sum + i % 10;
    }
    return sum;
 }


int [] GetArray (int length)
{
    int [] array = new int[length];  

    
    for (int i = 0; i < array.Length; i++)  
    {
       array[i] = new Random().Next(0, 100);
    }

    return array;
} 

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         Console.Write(array[i] + " ");
    }
    PrintArray(array);
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
