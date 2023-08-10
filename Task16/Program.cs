/*
Напишите программу, которая принимает на вход 2 числа и проверяет 
является ли одно число квадратом другого.
*/

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == number1 * number1)
{
    Console.WriteLine ($"Число {number2} является квадратом {number1}");
    // (number1 == number2 * number2 ||(или) number2 == number1 * number1)
}
else if (number1 == number2 * number2)
{
    Console.WriteLine ($"Число {number1} является квадратом {number2}");
}
else 
{
    Console.WriteLine ("Ни одно число не является квадратом другого");
}