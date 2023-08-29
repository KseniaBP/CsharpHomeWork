/*
Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
*/

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Quantity(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}
Console.WriteLine ($"В числе {userNumber} {Quantity(userNumber)} цифр(а/ы)");