// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
// заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


// ====== вывод массива (с авто заполнением элементов) ======

int[] array = new int[8]; // задаем массив из 8 эменентов

void RandomArray(int[] array)
{
    Random rand = new Random();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 33); // ограничение для вывода не больших чисел = 33 (по макс из условия)
        Console.Write(array[i] + ",");
    }
    Console.Write("]");
}
int[] arrayNew = new int[8];
RandomArray(array);



// ====== вывод массива (с ручным вводом элементов) =======

// int[] array = new int[8]; // задаем массив из 8 эменентов

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите элемент массива под индексом {i}: ");
//     array[i] = int.Parse(Console.ReadLine());
// }

// Console.Write("Вывод массива: [");

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + ",");
// }
// Console.Write("]");