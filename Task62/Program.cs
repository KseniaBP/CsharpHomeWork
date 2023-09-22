/*
 Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int[,] FillArray()
{
    Console.Write("Введите количество столбцов: ");
    int columnCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк: ");
    int rowCount = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rowCount, columnCount];
    int count = 1;
    int left = 0, right = columnCount - 1, top = 0, bottom = rowCount - 1;

    while (left <= right && top <= bottom)
    {
        for (int i = left; i <= right; i++)
            array[top, i] = count++;
        for (int j = top + 1; j <= bottom; j++)
            array[j, right] = count++;
        if (top < bottom)
        {
            for (int i = right - 1; i >= left; i--)
                array[bottom, i] = count++;
        }
        if (left < right)
        {
            for (int i = bottom - 1; i > top; i--)
                array[i, left] = count++;
        }

        left++;
        right--;
        top++;
        bottom--;
    }

    return array;
}
void PrintArray(int[,] arrayPrint)
{

    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write(arrayPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintArray(FillArray());