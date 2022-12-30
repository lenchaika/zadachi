// дз


Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input command: ");
        switch (Console.ReadLine())
        {
            case "Task2": Task2(); break;
            case "Task4": Task4(); break;
            case "Task6": Task6(); break;
            case "Task8": Task8(); break;
            case "Task10": Task10(); break;
            case "Task19": Task19(); break;
            case "Task25": Task25(); break;
            case "Task29": Task29(); break;
            case "Task28": Task28(); break;
            case "TaskN": TaskN(); break;
            case "Task30": Task30(); break;
            case "seminar4": seminar4(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}

void Task2 ()

{
    Console.WriteLine("Task2");
    int firstNumber = ReadInt("First Number");
    int secondNumber = ReadInt("Second Number");

    if (IsLargeThen(firstNumber, secondNumber))
    {
        Console.WriteLine("First Number > Second Number");
    }
    else
    {
         Console.WriteLine("Second Number > First Number");
    }
}


// принимает  3 числа и выдает максимальный

void Task4()
{
    Console.WriteLine("Task4:");
    int firstNumber = ReadInt("First number");
    int secondNumber = ReadInt("Second number");
    int thirdNumber = ReadInt("Third number");

    Console.WriteLine($"The largest value is {FindMax(firstNumber, secondNumber, thirdNumber)}");
}

// принимает на вход число и выдает является ли оно четным
void Task6()

{
    Console.WriteLine("Task 6:");
    int number = ReadInt("Number");
    string evenSuffix = string.Empty; // string.Empty = пустая строка
    if (!IsEven(number))
    {
        evenSuffix = "not";
    }

    Console.WriteLine($"Input number is {evenSuffix} even");
}

// на вход принимает число а на выходе показывает все четные числа от 1 до N

void Task8 ()
{
    Console.WriteLine("Task8");
    int n = ReadInt("N");
    Console.WriteLine(GetNumberAsLineUntil(n));
}

// принимаем трехзначное число и на выходе показываем вторую цифру этого числа
void Task10()
{

    Console.WriteLine("Task10");
    int number = ReadInt("number");
    int position = ReadInt("number");
    Console.WriteLine($"The second digit is {GetDigitFromNumber(number, 2)}");
}

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
void Task19()
{
    Console.WriteLine("Task19");
    string number = ReadInt("number").ToString();
    
    if(number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("It's a palindrom");
    }
    else
    {
        Console.WriteLine("It's not a palindrom");
    }


}

void Task25()
    {
        Console.WriteLine("Task25");
        int numberA = ReadInt("first number (A)");
        int numberB = ReadInt("second number (B)");

       Console.WriteLine($"The power {numberB} of number {numberA} is {Pow(numberA, numberB)}");
    }


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void Task29()
{
     Console.WriteLine("Task29");
    int[] array = GetArray(ReadInt("array length"));
    Console.WriteLine(ArrayToString(array));
}



void seminar4()//задача 24 - напишите программу которая принимает на вход число А и выдает сумму числе от 1 до А
{
    Console.WriteLine("seminar4");
    int number = ReadInt ("number");

    Console.WriteLine(GetSumUntil(number));

}

void TaskN()// программа принимает на вход число и выдает количество цифр // через математичексие операторы
{
    Console.WriteLine("TaskN");
    int number = ReadInt("number");
    int count = 0;
    while(number > 0)
    {
        number /=10;
        count++;
    }
    Console.WriteLine(count);
}

void Task28()// программа принимает на вход число N и выдаем произведение чисел от 1 до N - факториал
{
    Console.WriteLine("Task28");
    int number = ReadInt("number");
    Console.WriteLine(factorial(number));
}


void Task30()// выводит массив из 8 элементов заплненый нулями и единицами  в случайном порядке
{
    Console.WriteLine("Task30");
    
    int[] array = GetArray(ReadInt("array length"));
    
    Console.WriteLine(ArrayToString(array));

}

int [] GetArray (int length)// функция создания массива
{
    int [] array = new int[8];  // создали массив

    //заполняет пользователь массив
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }

    return array;
} 

int FindMax(int firstNumber, int secondNumber, int thirdNumber)
{
    int max = firstNumber;

    if (!IsLargeThen(firstNumber, secondNumber))
    {
        max = secondNumber;
    }
    if (IsLargeThen(thirdNumber, max))
    {
        max = thirdNumber;
    }

    return max;
} 



int ReadInt(string argumentName)// функция ввода числа
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine()); // возвращает от пользователя
}
bool IsLargeThen(int firstNumber, int secondNumber) // bool -тру или фолз принимает
{
    return firstNumber > secondNumber; // возвращает результат сравнения
}

bool IsEven(int number)
{
    return number % 2 == 0; // == -  сравнение (два вариант истина или ложь)
}


string GetNumberAsLineUntil(int n)
{
    string result = string.Empty;
    for (int i = 1; i < n; i++)
    if(IsEven(i))
    {
    result += $"{i}, ";
    }

    return result;
}


int GetDigitFromNumber(int number, int digitPosition)
{
    string numberString = number.ToString();
    int move = numberString.Length - digitPosition;
    return int.Parse(numberString[numberString.Length -
     digitPosition].ToString());
}

int Pow(int firstNumber, int secondNumber)// функция возведения в степень
{
    int result = 1;
    for (int i = 0;  i < secondNumber; i++)
    {
        result *= firstNumber;
    }
    return result;
}

//int [] GetArray (int length)// функция создания массива
//{
//    int [] array = new int[length];  // создали массив
//
    //заполняет пользователь массив
  //  for (int i = 0; i < array.Length; i++)
    //{
      //  array[i] = ReadInt($"element {i}");
   // }
//
//    return array;
//}



//массив вывод на экран
string ArrayToString(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
    result += $"{array[i]}, ";
    }
    return result;
}

 int GetSumUntil(int n) // функция суммы 
 {
    int result = 0;

    for (int i = 1; i <= n; i++)
    {
        result += i;
    }
    return result;
 }



int factorial(int n)
{
    int sum = 1;
    for (int i = 1; i <= n; i++)

    {
        sum *= i;
    }
   return sum;
}