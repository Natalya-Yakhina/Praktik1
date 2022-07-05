// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = int.Parse(Console.ReadLine());

int Stepen(int numberA, int numberB) // метод возвращающий значение типа int
{
    int stepen = 1;
    for (int i = 1; i <= numB; i++)
    {
        stepen = stepen * numA;
    }
    return stepen;
}
int stepen = Stepen(numA, numB);
Console.WriteLine($"Число {numA} в степени {numB} = " + stepen);
