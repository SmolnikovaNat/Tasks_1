﻿// Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    Console.WriteLine(i);
}

