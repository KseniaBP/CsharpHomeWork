/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] FillArray1()
{
    Console.Write("Введите количество столбцов для первого массива: ");
    int columnCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк для первого массива: ");
    int rowCount = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rowCount, columnCount];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }

    return array;
}
int[,] FillArray2(int rowCount2)
{
    Console.Write("Введите количество столбцов для второго массива: ");
    int columnCount2 = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rowCount2, columnCount2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
int[,] ArrayProd(int[,] productArray1, int[,] ProductArray2)
{
    int row1 = productArray1.GetLength(0);
    int column1 = productArray1.GetLength(1);
    int row2 = ProductArray2.GetLength(0);
    int column2 = ProductArray2.GetLength(1);
    int[,] result = new int[row1, column2];
    int prod = 1;

    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            for (int g = 0; g < column1; g++)
            {
                prod = productArray1[i, g] * ProductArray2[j, g];
                result[i, j] += prod;
            }
        }
    }

    return result;
}


int[,] array1 = FillArray1();
int rows = array1.GetLength(1);
int[,] array2 = FillArray2(rows);
int[,] productArrays = ArrayProd(array1, array2);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(productArrays);