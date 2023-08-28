/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X не равно 0 и Y не равно 0 и выдает номер четверти плоскости, в которой находится эта точка
*/

Console.WriteLine("Введите X и Y вашей точки: ");
int userX = Convert.ToInt32(Console.ReadLine());
int userY = Convert.ToInt32(Console.ReadLine());

if(userX > 0 && userY > 0)
{
    Console.WriteLine($"Координаты {userX} : {userY} находятся в первой четверти");
}
else if(userX < 0 && userY > 0)
{
    Console.WriteLine($"Координаты {userX} : {userY} находятся во второй четверти");
}
else if(userX < 0 && userY < 0)
{
    Console.WriteLine($"Координаты {userX} : {userY} находятся в третьей четверти");
}
else
{
    Console.WriteLine($"Координаты {userX} : {userY} находятся в четвертой четверти");
}