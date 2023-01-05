//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел ");
string input = Console.ReadLine();
int result = 0;
int [] numbers = StringToArray(input);
PrintArray(numbers);

int[] StringToArray(string input)
{
    int countNumbers = CountNumbersInString(input);
    int[] numbers = new int[countNumbers];
    int Number = 0;
    string nstring = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ' ')
        {
            nstring += input[i];
        }
        else
        {
            numbers[Number] = Convert.ToInt32(nstring);
            Number++;
            nstring = string.Empty;
        }
    }
    if(input[input.Length - 1] != ' ')
    numbers[Number] = Convert.ToInt32(nstring);
    return numbers;
}

int CountNumbersInString(string input)
{
    int count;
    if(input[input.Length - 1] == ' ')
    count = 0;
    else
    count = 1;

    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] == ' ')
        count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0)
    result++;
}
Console.WriteLine();
Console.WriteLine($"Количетво чисел > 0 -> {result}");