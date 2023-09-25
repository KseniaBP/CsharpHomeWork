/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите первое число: ");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());

int sum = SumMToN(userNumberM, userNumberN);
Console.WriteLine(sum);

int SumMToN(int numberM, int numberN)
{
    if (numberM == numberN) return numberM;
    else return numberM + SumMToN(numberM + 1, numberN);
}