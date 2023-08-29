/*
Напишите программу, которая принимает на входк координаты двух точек и находит расстояние между ними в  2D пространстве.
*/

Console.WriteLine("Введите xA");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите yA");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите xB");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите yB");
int yB = Convert.ToInt32(Console.ReadLine());

double resultAB = Math.Sqrt((xA-xB)*(xA-xB)+(yA-yB)*(yA-yB));
Console.WriteLine(Math.Round(resultAB, 2));