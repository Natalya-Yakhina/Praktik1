// Задача 8: Напишите программу, которая на вход принимает число (N),  
//а на выходе показывает все четные числа от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine()); // вводимое число N
// int num = Convert.ToInt32(Console.ReadLine()); // переменная четных чисел на выходе
// int a = 2; // условие от 1

// for (a = num; a <= N; a++)
//     {
//     if (a % 2 == 0);
//     }
//     {
// Console.WriteLine(a + " ");
//     }

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()); // вводимое число N
int num = Convert.ToInt32(Console.ReadLine());
int count = 1; // условие от 1

while (count <= N)
{
    if (num % 2 == 0)
    {
        Console.Write($"{num}", num+2);
    }
    else
    {
        count = count+1;
    }
}