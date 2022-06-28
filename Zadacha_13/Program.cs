// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num3 = 0;

if (num < 1000)
{
    num3 = (num % 10);
    Console.WriteLine ($"Третья цифра числа {num} = {num3}");
}
else
{
    num3 = (num / 100 % 10);
    Console.WriteLine ($"Третья цифра числа {num} = {num3}");
}
if (num < 100 )
{
    Console.WriteLine ($"Третьей цифры нет");
}