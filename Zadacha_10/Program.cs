// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine($"Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = 0;

if (num < 1000)
{
    newNum = ((num / 10) % 10);
    Console.WriteLine($"Вторая цифра числа {num} = {newNum}");
}
else
{
    Console.WriteLine("Ошибка!");
}