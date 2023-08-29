/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число"); 
int number = Convert.ToInt32(Console.ReadLine()); 
int result = 0; 
 
for (int i = 1; i < number + 1; i++) 
{ 
    result = i * i * i; 
    Console.WriteLine($"{result}"); 
}