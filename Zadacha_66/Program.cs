// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNatural(int m, int n)
{
    if (m > n) return 0;
    return m + SumNatural(m + 1, n); 
}
Console.WriteLine($"Сумма чисел = " + SumNatural(m, n));

//============================================
// int NumberSum(int m, int n)
// {
//  // if ((m == 0) && (n == 0)) return 0;
    // if (m > n) return m + SumNatural(m - 1, n)
    // if (m < n) return m + SumNatural(m + 1, n); 
// }