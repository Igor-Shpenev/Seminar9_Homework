// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void SeriesNumbers(int n)
{
    Console.Write(n + " ");
    if (n > 1) SeriesNumbers(n - 1);
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number< 1) Console.Write("Error"); 
else SeriesNumbers(number);