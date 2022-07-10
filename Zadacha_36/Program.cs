// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}

int SumNeChet(int[] arr) // метод вычисления суммы значений элементов массива на нечетных позициях
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0) sum += arr[i];  // != не равно
    }
    return sum;
}

int[] array = FillArray(6, -15, 15);
PrintArray(array);

int sumNeChet = SumNeChet(array);
Console.WriteLine($"Сумма элементов нечетных позиций = {sumNeChet}");