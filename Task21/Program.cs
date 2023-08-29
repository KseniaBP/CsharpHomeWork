/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты певрой точки");
int xA = Convert.ToInt32(Console.ReadLine());
int yA = Convert.ToInt32(Console.ReadLine());
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
int xB = Convert.ToInt32(Console.ReadLine());
int yB = Convert.ToInt32(Console.ReadLine());
int zB = Convert.ToInt32(Console.ReadLine());

double resultAB = Math.Sqrt((xA-xB)*(xA-xB)+(yA-yB)*(yA-yB)+(zA-zB)*(zA-zB));

Console.WriteLine(Math.Round(resultAB, 2));