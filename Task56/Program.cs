/* 
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] FillArray()
{
    Console.Write("Введите количество столбцов: ");
    int columnCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк: ");
    int rowCount = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rowCount, columnCount];
    Console.Write("Введите минимальное значение: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int max = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }

    return array;
}
void PrintArray(int[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(1); i++)
    {
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int[] SumRow(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRows[i] += array[i, j];
        }
    }

    return sumRows;
}
/*void ArraySum(int[] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write(arrayPrint[i]);
        if (i < arrayPrint.Length - 1) System.Console.Write("\t");
    }
}*/
void PrintRow(int[] array)
{
    int sum = array[0];
    int row = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (sum > array[i])
        {
            sum = array[i];
            row = i + 1;
        }
    }

    Console.WriteLine($"Сумма элементов в строке {row} является наименьшей и она равна {sum}");
}

int[,] userArray = FillArray();
int[] sumRow = SumRow(userArray);

PrintArray(userArray);
Console.WriteLine();
//ArraySum(sumRow);
PrintRow(sumRow);