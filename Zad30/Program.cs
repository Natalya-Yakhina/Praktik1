// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
// заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// 1.
// int[] array = new int[8];

// void FillArray(int[] collection) // заполнение массива
// {
//     //int length = collection.Length; // получение длинны массива
//     int index = 0;
//     while(index < collection.Length)
//     {
//         collection[index] = new Random().Next(1, 33);
//         index++;
//     }
// }

// void PrintArray(int[] coll) // вывод массива на печать
// {
//     int count = coll.Length;
//     int index = 0;
//     Console.Write("[");
//     while(index < coll.Length)
//     {
//         Console.Write($"{coll[index]} ");
//         index++;
//     }
// Console.Write("]");
// }

// FillArray(array);
// PrintArray(array);

// 2.
// Random rand = new Random(); // отдельно создаем
// Console.Write("[");
// for (int i = 0; i < 8; i++)
// {
//     array[i] = rand.Next(1, 33); // задаем некст
//     Console.Write(array[i] + " ");
// }
// Console.Write("]");


// 4.

// void RandomArray(int[] array)
// {
//     Random rnd = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(0,100); // ограничение для вывода не слишком больших случайных чисел 
//         Console.Write(array[i] + ", ");
//     }
// }

// int[] arr = new int[8];
// RandomArray(arr);




// // Задача 3: Напишите программу, которая задаёт массив из 8 элементов 
// случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

// int [] createRandArray (string msg)
// {
//     Console.WriteLine("Введите количество элементов массива");
//     string Value = Console.ReadLine();
//     int quantityElements = int.Parse(Value);
//     if (quantityElements < 1)
//     {
//         Console.WriteLine("Должно быть введено натуральное число, повторите ввод");
//         Value = Console.ReadLine();
//         quantityElements = int.Parse(Value);

//         int[] array = new int[quantityElements];
//         Random rand = new Random();
//         for (int i = 0; i < quantityElements; i++)
//              {
//                 array[i] = rand.Next();
//                 Console.Write ($"{array[i]}, ");
//              }
//              return array;
//     }
//     else
//     {
//         int[] array = new int[quantityElements];
//         Random rand = new Random();
//         for (int i = 0; i < quantityElements; i++)
//              {
//                 array [i] = rand.Next();
//                 Console.Write ($"{array[i]}, ");
//              }
//              return array;
//     }
    
// }

// int [] RandArr = createRandArray ("Введите количество элементов массива");

// 5.
// void NewMasive()
// {
//     string [] array = new string [8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Введите {i+1} член массива: ");
//         array[i] = Console.ReadLine();

//     }
//     Console.WriteLine();
//     Console.WriteLine("Вот Ваш массив: ");
//     foreach(string s in array) Console.Write(s +" ");
// }

// NewMasive();++++



// rhenjq
// int[] makeArray()
// {
//     int[] arr = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         arr[i] = new Random().Next(1, 33);
//     }
//     return arr;
// }
// void printArray(int[] arg)
// {
//     Console.Write("[");
//     for (int i = 0; i < arg.Length; i++)
//     {
//         Console.Write(arg[i]);
//         if (i < arg.Length - 1) Console.Write(", ");
//         else Console.WriteLine("]");
//     }
// }
// //printArray(makeArray());

Console.WriteLine("Введите кол-во эл. массива");
int elementMassive = int.Parse(Console.ReadLine());
int[] myArray = new int[elementMassive];

for(int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t ");
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Вывод массива: ");

for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}
Console.ReadLine();