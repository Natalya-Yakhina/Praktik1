// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int SumNum(int numbers)
{
    int sum = 0;
    while(numbers > 0)
    {
        sum = sum + numbers % 10;
        numbers = numbers / 10; 
    }
    return sum;
}

int result = SumNum(num);
Console.WriteLine($"Сумма цифр в числе {num} = {result}");






// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int i = 0;
// int sum = 0;
// while( num > 0)
// {
//     sum = num % 10;
//     num = num / 10;
//     sum = sum + i;
// }
// Console.WriteLine($"Сумма цифр в числе {num} = {sum}");