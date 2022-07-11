// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
// 1. Создание массива вещественных чисел
double[] CreateArrayRnd(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.Next(min, max) + rnd.NextDouble(), 2);// Math.Round - метод обрезки числа после запятой (переменная, индекс)
    }
    return array;
}
//2. Поиск максимального элемента массива
double FindMaxElement(double[] array)
{
    int maxNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[maxNum])  maxNum = i;
    }
    return array[maxNum];
}
//3. Поиск минимального элемента массива
double FindMinElement(double[] array)
{
    int minNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minNum])  minNum = i;
    }
    return array[minNum];
}
// 4. Вывод массива
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Массив [");
        if (i < array.Length - 1) Console.Write(array[i] + ",  ");
        else Console.Write(array[i] + "]");
    }
    Console.WriteLine();
}

double[] array = CreateArrayRnd(5, 0, 99);
PrintArray(array);

FindMaxElement(array); 
double maxNum = FindMaxElement(array);
Console.WriteLine($"Максимальное значение массива: {maxNum}");

FindMinElement(array);
double minNum = FindMinElement(array);
Console.WriteLine($"Минимальное значение массива: {minNum}");

double result = Math.Round(FindMaxElement(array) - FindMinElement(array), 2);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {result}");