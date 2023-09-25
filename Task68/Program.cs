/* 
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите первое число: ");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());

int Ackermann(int userNumberN, int userNumberM)
{
    if (userNumberN == 0)
        return userNumberM + 1;
    else if (userNumberM == 0)
        return Ackermann(userNumberN - 1, 1);
    else
        return Ackermann(userNumberN - 1, Ackermann(userNumberN, userNumberM - 1));
}

Console.WriteLine(Ackermann(userNumberM, userNumberN));
