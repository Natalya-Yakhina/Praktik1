// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int Sum(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int sum = Sum(num);
Console.WriteLine($"Сумма цифр в числе {num} = " + sum);