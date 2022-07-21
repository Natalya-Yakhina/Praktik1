// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralArray(int n = 4)
{
    int[,] array = new int[n, n];
    
    int num = 1;
    int row = n;        // размер строк
    int column = n;     // размер столбцов
    int row0 = 0;       // нулевая строка
    int column0 = 0;    // нулевой столбец

    while(column0 < column)
    {
        for (int i = column0; i < column; i++)
        {
            array[row0, i] = num++;
        }
        column --;

        for (int j = row0 + 1; j < row; j++)
        {
            array[j, row - 1] = num++;
        }
        row--;
        for (int k = column - 1; k >= column0; k--)
        {
            array[column, k] = num++;
        }
        for (int l = row - 1; l > row0; l--)
        {
            array[l, column0] = num++;
        }
        column0++;
        row0++;
    }
    return array;
}
void PrintArray(int[,] array) // печать двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if (j == 0) Console.Write("|");
        if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3} | ");
        else Console.Write($"{array[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}

PrintArray(SpiralArray(4));