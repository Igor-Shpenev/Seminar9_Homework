// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return AckermanFunction(m - 1, 1);
    else if ((m > 0) && (n > 0)) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    else return n + 1;
}

Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 1 | n < 1) Console.Write("Error");
else Console.WriteLine(AckermanFunction(m, n));


