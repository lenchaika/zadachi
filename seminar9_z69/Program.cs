// Задача 69: напишите программу кот. на вход принимает числа А и В и возводит число
//число А в целую степень В с помощью рекурсии


int ProductAandB(int A, int B)
{
    if (B == 1)
    return A;
    else return(A * ProductAandB(A, B-1));
}
Console.WriteLine(ProductAandB(2, 4));

