/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] GetRandomArray(int arrayLength1, int start, int end)
{
    double[] array = new double[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1);
    }
    return array;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

void MinMaxDiff(double[] arrayDiff)
{
    double min = 0;
    double max = 0;
    for (int i = 1; i < arrayDiff.Length - 1; i++)
    {
        if (max < arrayDiff[i]) max = arrayDiff[i];
        else if (min > arrayDiff[i]) min = arrayDiff[i];
    }
    Console.WriteLine(Math.Round(arrayDiff[0] - arrayDiff[arrayDiff.Length - 1], 2));
}
/*
//Console.WriteLine ("Задай длинну массива: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine ("Задай минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine ("Задай максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());*/

double[] userArray = GetRandomArray(5, 1, 100);
PrintArray(userArray);
double[] MinMaxDiff(userArray);