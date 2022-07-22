// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

// ============= ФУНКЦИЯ АККЕРМАНА =============
// m + 1,                   n = 0
// A(n,m) = A(n-1, 1),      m = 0
// A(n - 1, A(n, m -1)),    m > 0, n > 0  

int FunctionAkkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return FunctionAkkerman(n - 1, 1);
    return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
}
Console.WriteLine($"Функция Аккермана = {FunctionAkkerman(n, m)}");