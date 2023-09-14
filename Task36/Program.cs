/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

void GetSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
    sum += array[i];
    }
    Console.WriteLine($"Сумма нечетных элементов равна {sum}");
}

Console.WriteLine ("Задай длинну массива: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Задай минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Задай максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] userArray = GetRandomArray (arrayL, min, max);
PrintArray(userArray);
GetSum(userArray);
Console.WriteLine(GetSum);
