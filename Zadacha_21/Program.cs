// Задача 21/ Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты точки: ");

Console.Write("ХА = ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("YA = ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("ZA = ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("XB = ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YB = ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("ZB = ");
int zb = Convert.ToInt32(Console.ReadLine());


double AB = Math.Sqrt(Math.Pow((xa - xb),2) + Math.Pow((ya - yb),2) + Math.Pow((za-zb), 2));
Console.WriteLine(Math.Round(AB, 2));