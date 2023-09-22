/* 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] FillArray()
{
    Console.Write("Введите количество столбцов: ");
    int columnCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк: ");
    int rowCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте глубину массива: ");
    int depth = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[rowCount, columnCount, depth];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
            {
                bool norepeat;
                int randomNumber = 0;
                do
                {
                    norepeat = false;
                    randomNumber = new Random().Next(10, 100);
                    foreach (var item in array)
                    {
                        if (item == randomNumber) norepeat = true;
                    }
                } while (norepeat);

                array[i, j, m] = randomNumber;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            for (int m = 0; m < arrayPrint.GetLength(2); m++)
            {
                Console.WriteLine($"{arrayPrint[i, j, m]} ({i}, {j}, {m})");
            }
        }
    }
}

int[,,] userArray = FillArray();
PrintArray(userArray);