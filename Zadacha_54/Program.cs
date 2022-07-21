// // Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-5, 15);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} | ");
        }
        Console.WriteLine();
    }
}

// int[,] SortIncreaseMatrix(int[,] matrix) // сортировка элементов по возрастанию
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//         {
//             for (int min = j; min < matrix.GetLength(1); min++)
//             {
//                 if (matrix[i, j] > matrix[i, min])
//                 {
//                     int temp = matrix[i, j];
//                     matrix[i, j] = matrix[i, min];
//                     matrix[i, min] = temp;
//                 }
//             }
//         }
//     }
//     return matrix;
// }

int[,] SortDescendingMatrix(int[,] matrix) // сортировка элементов по убыванию
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int max = j; max < matrix.GetLength(1); max++)
            {
                if (matrix[i, j] < matrix[i, max])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, max];
                    matrix[i, max] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrixRndInt(3, 4);
PrintMatrix(matrix);
Console.WriteLine();

// SortIncreaseMatrix(matrix); // вызов метода по возрастанию
SortDescendingMatrix(matrix); // вызов метода по убыванию
PrintMatrix(matrix);