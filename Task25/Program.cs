/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int Exponent(int number, int mult)
{
    int result = 1;
    for (int i = 1; i <= mult; i++)
    {
        result = result * number;
    }
    return result;
}

int exp = Exponent(number1, number2);
Console.WriteLine(exp);