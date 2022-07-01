// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да





Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();


while(number!.Length == 5)
{
  if (number[0] == number[4] && number[1] == number[3])
  {
      Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else
  {
      Console.WriteLine($"Ваше число: {number} - не палиндром.");
  }
  return;
}


// void NewNumber(string number)
// {
//   if (number[0]==number[4] || number[1]==number[3])
//   {
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else 
//   {
//     Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
//   }
// }
// if(number!.Length == 5)
// {
//   NewNumber(number);
// }

// if (number!.Length == 5)
// {
//   NewNumber(number);
// }
// else Console.NewNumber($"ОШИБКА!");



// int num = Convert.ToInt32(Console.ReadLine());
//int numNew = 0;

// while (num > 0)
// {
//     numNew = num / 10;
//     numNew = numNew * 10 + numNew;
//     num = num / 10;
// }
// if (num == numNew)
// {
//     Console.WriteLine("палиндромом");
// }
// else
// {
//     Console.WriteLine("не палиндромом");
// }


// for (int i = Array.Length - 1; i >= 0; i--)
//     {
//         return;
//         Console.WriteLine($"NumNew = {i}");
//     }
