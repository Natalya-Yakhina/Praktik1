// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numNew = 0; 
int cnt = 0;
for (int n = num; n > 0; n /= 10, cnt++);
//  {
//     Console.WriteLine($"Длинна числа: {cnt}"); // размер числа
//  }
if (cnt == 3) 
{
    numNew = ((num % 10));
    Console.WriteLine($"Третья цифра числа {num} = {numNew}");
}
else if (cnt <= 2)
{
    Console.WriteLine("Третьей цифры нет");
}
if (cnt == 4)
{
    numNew = (num / 10 % 10);
    Console.WriteLine ($"Третья цифра числа {num} = {numNew}");
}
if (cnt == 5)
{
    numNew = (num / 100 % 10);
    Console.WriteLine ($"Третья цифра числа {num} = {numNew}");
}

// ПОИСК ТРЕТЬЕЙ ЦИФРЫ ПО ИНДЕКСУ

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int digitIndex = 2; // индекс третьей цифры

// if (num > 99)
// {
//     int digit = num.ToString()[digitIndex]- '0';
//     Console.WriteLine($"Третья цифра числа {num} = {digit}");
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }
