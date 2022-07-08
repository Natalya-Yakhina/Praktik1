// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = new int[7];

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-10, 90);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
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

FillArray(array);
PrintArray(array);

int sumNeChet = SumNeChet(array);
Console.WriteLine($"Сумма элементов нечетных позиций = {sumNeChet}");
