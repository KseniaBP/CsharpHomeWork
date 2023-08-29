/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат в этой четверти
*/

Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Координаты оси X > 0. Координаты оси Y > 0");
}
else if (number == 2)
{
    Console.WriteLine("Координаты оси X < 0. Координаты оси Y > 0");
}
else if (number == 3)
{
    Console.WriteLine("Координаты оси X < 0. Координаты оси Y < 0");
}
else if (number == 4)
{
    Console.WriteLine("Координаты оси X > 0. Координаты оси Y < 0");
}
else
{
    Console.WriteLine("Нет такой четверти");
}