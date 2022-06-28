// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("нет"); break;
    case 2: Console.WriteLine("нет"); break;
    case 3: Console.WriteLine("нет"); break;
    case 4: Console.WriteLine("нет"); break;
    case 5: Console.WriteLine("нет"); break;
    case 6: Console.WriteLine("да"); break;
    case 7: Console.WriteLine("да"); break;
    default: Console.WriteLine("Нет такого дня недели"); break;
}



// если в кейс записать дни недели:

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// switch (num)
// {
//     case 1: Console.WriteLine("Понедельник"); break;
//     case 2: Console.WriteLine("Вторник"); break;
//     case 3: Console.WriteLine("Среда"); break;
//     case 4: Console.WriteLine("Четверг"); break;
//     case 5: Console.WriteLine("Пятница"); break;
//     case 6: Console.WriteLine("Суббота"); break;
//     case 7: Console.WriteLine("Воскресенье"); break;
//     default: Console.WriteLine("Нет такого дня недели"); break;
// if (num > 5 && num <= 7)
// {
//     Console.WriteLine("да");
// }
// else if (num <= 7)
// {
//     Console.WriteLine("нет");
// }
