﻿// Задача 8: Напишите программу, которая на вход принимает число (N),  
// а на выходе показывает все четные числа от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
for (i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    Console.Write($"{i} ,", i);
}
return 0;