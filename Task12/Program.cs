/*
Напишите программу, которая будет принимать на вход 2 числа и выводить 
является ли второе число кратным первому. Если второе число не кратно первому
то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)

{
    Console.WriteLine($"Число {number1} кратно {number2}");
}
else
{
    int number3 = number1 % number2;
    Console.WriteLine($"Число {number1} некратно {number2}. Остаток от деления равен {number3}");
}