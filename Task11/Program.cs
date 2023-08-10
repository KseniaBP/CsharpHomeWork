/*
Напишите программу, которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа.
456 -> 46
*/

int number = new Random().Next(100, 1000);
Console.WriteLine (number);

int numberOne = number / 100;
// Console.WriteLine(numberOne);

int numberThree = number % 10;
// Console.WriteLine(numberThree);

Console.Write ($"{numberOne}{numberThree}");
