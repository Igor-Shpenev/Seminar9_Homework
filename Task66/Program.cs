// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int m, int n)
{
    int sum = 0;
    if (Math.Max(m, n) != Math.Min(m, n)) sum = SumNumbers(Math.Max(m, n) - 1, Math.Min(m, n));
    sum += Math.Max(m, n);
    return sum;
}

Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of the numbers in the range from {m} to {n} is {SumNumbers(m, n)}");
