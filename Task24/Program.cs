/*
Напишите программу, которая принимает на вход число A и выдает сумму числел от 1 до A
*/

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
/*int sum = 0;

for (int i = 1; i <= userNumber; i++)
{
    sum += i;
}

Console.WriteLine(sum);*/

int SumOfNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= userNumber; i++)
{
    sum += i;
}
    return sum;
}
Console.WriteLine($"сумма чисел от 1 до {userNumber} равна {SumOfNumber(userNumber)}");