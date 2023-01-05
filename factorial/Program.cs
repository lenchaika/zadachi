﻿// Определим функцию или метод, который будет принимать число, факториал которого нужно 
//вычислить. Как вы понимаете, это снова метод, который принимает какой-то аргумент (в частности, 
//число) и возвращает факториал этого числа.

double Factorial(int n)
{
 // 1! = 1
 // 0! = 1
    if(n == 1) return 1; //дошли до единицы и вернули единицу
    else return n * Factorial(n-1);// в противном случае берем текущее значение и умножаем на факториал
}
for (int i = 1; i < 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");
}