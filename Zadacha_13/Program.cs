// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digitIndex = 2; // индекс третьей цифры

if (num > 99)
{
    int digit = num.ToString()[digitIndex]- '0';
    Console.WriteLine($"Третья цифра числа {num} = {digit}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}



// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int numNew = 0;

// if (num > 100 && num < 999)  // от 100 до 999
//     {
//         numNew = (num % 10);
//         Console.WriteLine($"Третья цифра числа {num} = {numNew}");
//     }
//     else
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// if (num < 9999) 
//     {
//         numNew = (num / 10 % 10);
//         Console.WriteLine ($"Третья цифра числа {num} = {numNew}"); 
//     }
// // if (num < 99999)
// //     {
// //         numNew = (num / 100 % 10);
// //         Console.WriteLine ($"Третья цифра числа {num} = {numNew}");
// //     }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }