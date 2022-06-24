// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

int max = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    num1 = max;
}
else
{
    num2 = max;
}
// }
// if (num2 > num3)
// {
//     num2 = max;
// }
// else
// {
//     num3 = max;
// }
// if (num3 > num1)
// {
//     num3 = max;
// }
// else
// {
//     num1 = max;
// }
    Console.WriteLine($"максимальное число: {max}");