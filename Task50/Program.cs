/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] FillArray()
{
    Console.Write("Введите кол-во столбцов: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }

    return array;
}
void PrintArray(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(1); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void FindNumber(int[,] arrayFindNumber)
{
    Console.Write("Введите число, которое нужно найти в массиве: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    bool checkNumber = true;

    for (int i = 0; i < arrayFindNumber.GetLength(0); i++)
    {
        for (int j = 0; j < arrayFindNumber.GetLength(1); j++)
        {
            if (arrayFindNumber[i, j] == userNumber)
            {
                Console.WriteLine($"Число {userNumber} находится на {i + 1} строке, {j + 1} столбце");
                checkNumber = false;
            }
        }
    }

    if (checkNumber) Console.WriteLine($"Числа {userNumber} нет в массиве");
}

int[,] userArray = FillArray();
PrintArray(userArray);
FindNumber(userArray);