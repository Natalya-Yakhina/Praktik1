// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




Console.Clear();
Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();
while (number!.Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else
    {
        Console.WriteLine($"Ваше число: {number} - не палиндром.");
    }
    return;
}
if (number!.Length > 5)
{
    Console.WriteLine("ОШИБКА!!!");
}