/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
int[,] SortArray(int[,] arraySort)
{
    bool sorted;
    do
    {
        sorted = false;
        for (int i = 0; i < arraySort.GetLength(0); i++)
        {
            for (int j = 1; j < arraySort.GetLength(1); j++)
            {
                if (arraySort[i, j - 1] < arraySort[i, j])
                {
                    int temp = arraySort[i, j - 1];
                    arraySort[i, j - 1] = arraySort[i, j];
                    arraySort[i, j] = temp;
                    sorted = true;
                }
            }
        }
    } while (sorted);

    return arraySort;
}

int[,] userArray = FillArray();
PrintArray(userArray);
Console.WriteLine();
PrintArray(SortArray(userArray));