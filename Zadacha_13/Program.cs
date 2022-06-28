// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digitIndex = 2; // индекс третьей цифры

if (num > 99)
{
    int digit = num.ToString()[digitIndex] - '0';
    Console.WriteLine($"Третья цифра числа {num} = {digit}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}