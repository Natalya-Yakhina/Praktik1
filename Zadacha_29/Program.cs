// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
// заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


// int[] array = new int[8];
// void RandomArray(int[] array)
// {
//     Random rand = new Random();
//     Console.Write("[");
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(0, 33); // ограничение для вывода не больших чисел = 33 (по макс из условий)
//         Console.Write(array[i] + ",");
//     }
//         Console.Write("]");
// }
// int[] arrayNew = new int[8];
// RandomArray(array);



// ввод элементов массива

Console.WriteLine("Введите кол-во эл. массива");
int num = int.Parse(Console.ReadLine()); // ввод числа
int[] array = new int[num]; // ввод массива из числа

for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Вывод массива: ");

for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}
Console.ReadLine();