// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


// double[] array = new double[7];
// void FillArray(double[] array)
// {
//     Random rnd = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(1, 80);
//         Console.Write($"{array[i]} ");
//     }
//     // double max = 0;
//     // double min = 0;
    
//     // for (int i = 0; i < array.Length; i++)
//     // {
//     //    if (max < array[i])
//     //     {
//     //         max = array[i];
//     //     }
//     //     if (min > array[i])
//     //     {
//     //         min = array[i];
//     //     }
//     // }
//     // double result = max - min;
//     // Console.WriteLine($"разницa между максимальным и минимальным элементов массива: {result}");
// }

// void PrintArray(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i < arr.Length - 1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i] + "]");
//     }
// }
// PrintArray(array);
// FillArray(array);

// int GetMaxMinElem(int[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (max < array[i])
//         {
//             max = array[i];
//         }
//         if (min > array[i])
//         {
//             min = array[i];
//         }
//     }
//     double result = max - min;
//     return result;
// }

// void PrintArray(int[] array3)
// {
//     for (int i = 0; i < array3.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i < array3.Length - 1) Console.Write(array3[i] + ",");
//         else Console.Write(array3[i] + "]");
//     }
// }

// void PrintDifMaxMin(int dif)
// {
//     Console.WriteLine();
//     Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {dif}");
// }

// double[] array = CreateArrayRnd(5, 0, 9,9);
// PrintArray(array);
// double difMaxMin = GetMaxMinElem(array);
// PrintDifMaxMin(difMaxMin);