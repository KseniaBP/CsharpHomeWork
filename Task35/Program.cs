/*
Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массиваб значения которых лежат в отрезке [10, 99]
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123.
*/


int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int[] array = new int[arrayLength1];
    for (int i = 0; i <array.Length; i++)
    {
        array [i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int [] arrayToPrint)
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

int QuantityNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 99 && array[i] >= 10)
        {
            count = count +1;
        }
    }
    return count;
}

Console.WriteLine ("Задай длинну массива: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Задай минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Задай максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] userArray = GetRandomArray(arrayL, min, max);
PrintArray(userArray);
int kolvo = QuantityNumber(userArray);
Console.WriteLine(kolvo);