/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
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
double[] FindAverage(int[,] arrayAvgColomns)
{
    double[] result = new double[arrayAvgColomns.GetLength(1)];

    for (int i = 0; i < arrayAvgColomns.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arrayAvgColomns.GetLength(0); j++)
        {
            sum = sum + arrayAvgColomns[j, i];
        }
        result[i] = sum / arrayAvgColomns.GetLength(1);
    }

    return result;
}
void PrintAverage(double[] arrayForPrint)
{
    Console.Write("Среднее арифметическое каждого столбца: \t");
    System.Console.WriteLine();
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(Math.Round(arrayForPrint[i], 1));
        if (i < arrayForPrint.Length - 1) System.Console.Write("\t");
    }
}

int[,] userArray = FillArray();
double[] avg = FindAverage(userArray);
PrintArray(userArray);
PrintAverage(avg);